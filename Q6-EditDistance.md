Program that take two string and return the distance between them. The distance is the amount of insertions and deletions needed to transform the first string to the second. 






- input : two string .

- output : the distance between them .It includes insertions and deletions .





0- initialize counter for insertions . set to 0 .

0- initialize counter for deletions . set to 0 .

- first remove every common character between them . 

- the remain characters in first string is deletions . for each character increment the counter of deletions.

- the remain characters in second string is insertions . for each character increment the counter of insertions.

- at the end we return the amount of insertions and deletions .