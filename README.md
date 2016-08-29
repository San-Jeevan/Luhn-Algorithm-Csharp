# Luhn-Algorithm-Csharp
Control creditcard numbers or generate last digit in a KID number


USAGE:

4925000000000079 is a valid creditcard number

Mod10("492500000000007") will return 9

==Description==
The formula verifies a number against its included [[check digit]], which is usually appended to a partial account number to generate the full account number. This number must pass the following test:

# From the rightmost digit, which is the check digit, moving left, double the value of every second digit; if the product of this doubling operation is greater than 9 (e.g., 8 × 2 = 16), then sum the digits of the products (e.g., 16: 1 + 6 = 7, 18: 1 + 8 = 9) or alternatively subtract 9 from the product (e.g., 16: 16 - 9 = 7, 18: 18 - 9 = 9).
# Take the sum of all the digits.
# If the total [[modular arithmetic|modulo]] 10 is equal to 0 (if the total ends in zero) then the number is valid according to the Luhn formula; else it is not valid.

Assume an example of an account number "7992739871" that will have a check digit added, making it of the form 7992739871x:

{| class="wikitable" style="text-align:center;border:none;background:transparent;"
! Account number
| style="width:1.5em" | 7
| style="width:1.5em" | 9
| style="width:1.5em" | 9
| style="width:1.5em" | 2
| style="width:1.5em" | 7
| style="width:1.5em" | 3
| style="width:1.5em" | 9
| style="width:1.5em" | 8
| style="width:1.5em" | 7
| style="width:1.5em" | 1
| style="width:1.5em" | '''x'''
| rowspan="2" style="border:none;background:transparent;"|
|-
! Double every other
| 7
| style="background: #FFA;" | '''18'''
| 9
| style="background: #FFA;" | '''4'''
| 7
| style="background: #FFA;" | '''6'''
| 9
| style="background: #FFA;" | '''16'''
| 7
| style="background: #FFA;" | '''2'''
| '''x'''
|-
! Sum digits
|7
|'''9'''
|9
|4
|7
|6
|9
|'''7'''
|7
|2
|'''x'''
|}

