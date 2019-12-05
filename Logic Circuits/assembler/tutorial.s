.text #specifies that what follows are instructions
.global main #specifies that the label "main" is globally accessible
main: #entry point into the program
sw $0, 0x73004($0) #enable individual control of SSD segments
addi $2, $0, 0 #initialise loop counter to zero
loop:
sgei $8, $2, 12 #has the loop finished?
bnez $8, main #if so, go to "main"
jal write #write the pattern to the SSD
jal delay #delay so it can actually be seen
addi $2, $2, 2 #increment loop counter
j loop #go around again
write:
lw $1, 0x73003($0) #transfer the right SSD contents to the left SSD
sw $1, 0x73002($0)
lw $1, hello($2) #load the new pattern to the right SSD
sw $1, 0x73003($0)
jr $ra #return
delay:
addui $9, $0, 0xFFFF #a big number to count down from
slli $9, $9, 2 #make it even bigger
delayLoop:
subui $9, $9, 1 #around we go...
bnez $9, delayLoop
jr $ra #return
.data #specifies that what follows are data with initial values
hello: #SSD patterns to encode "HELLO 104"
.word 0x76 #H
.word 0x79 #E
.word 0x38 #L
.word 0x38 #L
.word 0x3F #O
.word 0x00
.word 0x06 #1
.word 0x3F #0
.word 0x66 #4
.word 0x00
.word 0x00
.word 0x00