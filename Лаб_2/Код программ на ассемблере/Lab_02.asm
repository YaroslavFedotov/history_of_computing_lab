SEG1 	SEGMENT
OPER1 DB 5
OPER2 DB 3 
SEG1	 ENDS
SEG2 	SEGMENT
RESULT DB ? 
SEG2 ENDS

CODE 	SEGMENT
ASSUME CS:  CODE,  DS:SEG1,  ES:SEG2 
START:		MOV AX, SEG1
		MOV	DS, AX

MOV	AX, SEG2
	MOV	ES, AX
	MOV	BH, OPER1
ADD	BH, OPER2
	MOV	RESULT, BH
MOV AH, 4CH
INT 21H
CODE 	ENDS
END START
