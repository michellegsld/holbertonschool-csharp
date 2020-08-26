## README for 0x09-csharp-linear_algebra ##
### A directory within the holbertonschool-csharp repo ###

| File Name | Description |
| --------- | ----------- |
| 0-pythagoras | **Task: 0. Pythagoras** <br> The length of `AC`, given the triangle `ABC` where `AB` = `64` and `BC` = `121`. |
| 1-magnitude_2D | **Task: 1. Magnitude #0 - 2D** <br> The length of vector <b>v</b>, assuming its origin is `0`, `0` and <b>v</b> = `(3, 9)`. |
| 2-magnitude_3D | **Task: 2. Magnitude #1 - 3D** <br> The length of vector <b>v</b>, assuming its origin is `0`, `0`, `0` and <b>v</b> = `(7, -3, -9)`. |
| 3-magnitude/ <br> 3-magnitude/3-magnitude.csproj <br> 3-magnitude/3-magnitude.cs | **Task: 3. Magnitude #2** <br> A method that calculates and returns the length of a given vector. <ul><li>Class: `VectorMath`</li><li>Prototype: `public static double Magnitude(double[] vector)`</li><li>The vector can be 2D or 3D, if neither then returns `-1`.</li><li>The return value is rounded to the nearest tenth.</li></ul> |
| 4-vector_addition_2D | **Task: 4. Vector addition #0 - 2D** <br> The sum of the 2D vectors <b>v</b> and <b>u</b>, where <b>v</b> = `(8, -11)` and <b>u</b> = `(-4, 9)`. |
| 5-vector_addition_3D | **Task: 5. Vector addition #1 - 3D** <br> The sum of the 2D vectors <b>v</b> and <b>u</b>, where <b>v</b> = `(14, -2, 0)` and <b>u</b> = `(-3, 23, 50)`. |
| 6-vector_addition/ <br> 6-vector_addition/6-vector_addition.csproj <br> 6-vector_addition/6-vector_addition.cs | **Task: 6. Vector addition #2** <br> A method that adds two vectors and returns the resulting vector. <ul><li>Class: `VectorMath`</li><li>Prototype: `public static double[] Add(double[] vector1, double[] vector2)`</li><li>The vector can be 2D or 3D, if neither then returns `-1`.</li><li>If the vectors are not of the same size, returns a vector containing `-1`.</li></ul> |
| 7-vector_scalar_mul_2D | **Task: 7. Vector-scalar multiplication #0 - 2D** <br> The result of multiplying the 2D vector <b>v</b> and scalar <i>x</i>, where <b>v</b> = `(98, 972)` and <i>x</i> = `0.5`. |
| 8-vector_scalar_mul_3D | **Task: 8. Vector-scalar multiplication #1 - 3D** <br> The result of multiplying the 3D vector <b>v</b> and scalar <i>x</i>, where <b>v</b> = `(0, -16, 31)` and <i>x</i> = `4`. |
| 9-vector_scalar_mul/ <br> 9-vector_scalar_mul/9-vector_scalar_mul.csproj <br> 9-vector_scalar_mul/9-vector_scalar_mul.cs | **Task: 9. Vector-scalar multiplication #2** <br> A method that multiplies a vector and a scalar and returns the resulting vector. <ul><li>Class: `VectorMath`</li><li>Prototype: `public static double[] Multiply(double[] vector, double scalar)`</li><li>The vectors can be 2D or 3D, if neither then returns `-1`.</li></ul> |
| 10-dot_product_2D | **Task: 10. Dot product #0 - 2D** <br> The dot product of <b>v</b> and <b>u</b>, where <b>v</b> = `(1, 3)` and <b>u</b> = `(-2, 5)`. |
| 11-dot_product_3D | **Task: 11. Dot product #1 - 3D** <br> The dot product of <b>v</b> and <b>u</b>, where <b>v</b> = `(-4, 0, 10)` and <b>u</b> = `(3, 7, -9)`. |
| 12-dot_product/ <br> 12-dot_product/12-dot_product.csproj <br> 12-dot_product/12-dot_product.cs | **Task: 12. Dot product #2** <br> A method that calculates dot product of either two 2D or two 3D vectors. <ul><li>Class: `VectorMath`</li><li>Prototype: `public static double DotProduct(double[] vector1, double[] vector2)`</li><li>The vectors can be either both 2D or both 3D.</li><li>If neither are 2D or 3D, or both vectors are not the same size, then returns `-1`.</li></ul> |
| 13-matrix_addition | **Task: 13. Matrix addition #0** <br> The result of adding two matrices `M` and `N`, where: <br> <b>M</b> = <br>`(14, -3, 0)`<br>`(-11, -5, 3)`<br>`(2, -9, 13)`<br> <br> <b>N</b> = <br>`(6, 16, 21)`<br>`(5, 2, 0)`<br>`(1, 3, 7)`<br> |
| 14-matrix_addition/ <br> 14-matrix_addition/14-matrix_addition.csproj <br> 14-matrix_addition/14-matrix_addition.cs | **Task: 14. Matrix addition #1** <br> A method that adds two matrices and returns the resulting matrix. <ul><li>Class: `MatrixMath`</li><li>Prototype: `public static double[,] Add(double[,] matrix1, double[,] matrix2)`</li><li>The matrices can be either both 2D or both 3D</li><li>If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing `-1`.</li></ul> |
| 15-matrix_scalar_mul | **Task: 15. Matrix-scalar multiplication #0** <br> What is the result of multiplying the matrix <b>M</b> and scalar <i>x</i>, where: <br> <b>M</b> = <br> `(-13, 10, 18)`<br>`(2, 0, 14)`<br>`(-4, -5, 2)`<br><br><i>x</i> = `4`. |
| 16-matrix_scalar_mul/ <br> 16-matrix_scalar_mul/16-matrix_scalar_mul.csproj <br> 16-matrix_scalar_mul/16-matrix_scalar_mul.cs | **Task: 16. Matrix-scalar multiplication #1** <br> A method that multiplies a matrix and a scalar and returns the resulting matrix. <ul><li>Class: `MatrixMath`</li><li>Prototype: `public static double[,] MultiplyScalar(double[,] matrix, double scalar)`</li><li>The matrix can be either 2D or 3D</li><li>If the matrix is not a 2D or 3D matrix, returns a matrix containing `-1`.</li></ul> |
| 17-matrix_matrix_mul | **Task: 17. Matrix-matrix multiplication #0** <br> What is the result of multiplying two matrices <b>M</b> and <b>N</b>, where: <br> <b>M</b> = <br> `(2, 3)`<br>`(-1, 0)`<br><br><b>N</b> = <br>`(1, 7)` <br> `(-8, -2)`. |
| 18-matrix_matrix_mul/ <br> 18-matrix_matrix_mul/18-matrix_matrix_mul.csproj <br> 18-matrix_matrix_mul/18-matrix_matrix_mul.cs | **Task: 18. Matrix-matrix multiplication #1** <br> A method that multiplies two matrices and returns the resulting matrix. <ul><li>Class: `MatrixMath`</li><li>Prototype: `public static double[,] Multiply(double[,] matrix1, double[,] matrix2)`</li><li>The matrices will not necessarily be square or have the same dimensions</li><li>If the matrices cannot be multiplied, a matrix containing `-1` is returned</li></ul> |
| 19-matrix_rotate_2D | **Task: 19. Matrix rotation #0** <br> The resulting matrix after rotating the matrix <b>M</b> by angle <i>θ</i> (in radians), where: <br> <b>M</b> = <br>`(1, 2)`<br>`(3, 4)` <br><br> <i>θ</i> = `-1.57` |
| 20-matrix_rotate_2D/ <br> 20-matrix_rotate_2D/20-matrix_rotate_2D.csproj <br> 20-matrix_rotate_2D/20-matrix_rotate_2D.cs | **Task: 20. Matrix rotation #1** <br> A method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix. <ul><li>Class: `MatrixMath`</li><li>Prototype: `public static double[,] Rotate2D(double[,] matrix, double angle)`</li><li>If the matrix is of an invalid size, returns a matrix containing `-1`.</li><li>"Rotation" in this context is applied to the value of each element in the matrix, not changing the positions of the values in the matrix</li></ul> |
| 23-matrix_shear_2D | **Task: 21. Matrix shear #0** <br> The resulting matrix after shearing the matrix <b>M</b> by the shear factor <i>s</i> in the `X` direction, where: <br> <b>M</b> = <br>`(1, 2)`<br>`(3, 4)` <br><br> <i>s</i> = `2` |
| 24-matrix_shear_2D/ <br> 24-matrix_shear_2D/24-matrix_shear_2D.csproj <br> 24-matrix_shear_2D/24-matrix_shear_2D.cs | **Task: 22. Matrix shear #1** <br> A method that shears a square 2D matrix by a given shear factor and returns the resulting matrix. <ul><li>Class: `MatrixMath`</li><li>Prototype: `public static double[,] Shear2D(double[,] matrix, char direction, double factor)`</li><li>The shear factor can be in either the X or Y direction but not both</li><li>If the matrix is of an invalid size, returns a matrix containing `-1`</li><li>If given an axis that is not `x` or `y`, returns a matrix containing `-1`</li></ul> |
| 25-matrix_transpose/ <br> 25-matrix_transpose/25-matrix_transpose.csproj <br> 25-matrix_transpose/25-matrix_transpose.cs | **Task: 23. Transpose matrix** <br> A method that returns the resulting matrix after transposing it. <ul><li>Class: `MatrixMath`</li><li>Prototype: `public static double[,] Transpose(double[,] matrix)`</li><li>The matrix can be of any dimension or size</li><li>If the matrix is empty, returns an empty matrix</li></ul> |
| 26-determinant_2D | **Task: 24. Determinant #0** <br> The determinate of matrix <b>M</b>, where: <br> <b>M</b> = <br>`(2, 2)`<br>`(-9, 4)` |
| 27-determinant_3D | **Task: 25. Determinant #1** <br> The determinate of matrix <b>M</b>, where: <br> <b>M</b> = <br>`(-4, 9, 0)`<br>`(1, -2, 1)`<br>`(3, -4, 2)` |
| 28-determinant/ <br> 28-determinant/28-determinant.csproj <br> 28-determinant/28-determinant.cs | **Task: 26. Determinant #3** <br> A method that calculates the determinate of a matrix. <ul><li>Class: `MatrixMath`</li><li>Prototype: `public static double Determinant(double[,] matrix)`</li><li>If the matrix isn't 2D or 3D, returns `-1`</li></ul> |
| 29-cross_product | **Task: 27. Cross product #0** <br> The cross product of <b>v</b> and <b>u</b>, where <b>v</b> = `(2, -2, 1)` and <b>u</b> = `(-8, 8, -4)`. |
| 30-cross_product/ <br> 30-cross_product/30-cross_product.csproj <br> 30-cross_product/30-cross_product.cs | **Task: 28. Cross product #1** <br> A method that calculates the cross product of two 3D vectors and returns the resulting vector. <ul><li>Class: `VectorMath`</li><li>Prototype: `public static double[] CrossProduct(double[] vector1, double[] vector2)`</li><li>If either vector is not a 3D vector, returns a vector containing `-1`</li></ul> |
| 31-inverse_2D | **Task: 29. Inverse #0** <br> The inverse of matrix <b>M</b>, where: <br> <b>M</b> = <br>`(1, 2)`<br>`(3, 4)` |
| 32-inverse_3D | **Task: 30. Inverse #1** <br> The inverse of matrix <b>M</b> rounded to the nearest tenth, where: <br> <b>M</b> = <br>`(11, 8, 7)`<br>`(2, 13, 1)`<br>`(4, 0, 17)` |
| 33-inverse_2D/ <br> 33-inverse_2D/33-inverse_2D.csproj <br> 33-inverse_2D/33-inverse_2D.cs | **Task: 31. Inverse #2** <br> A method that calculates the cross product of two 3D vectors and returns the resulting vector. <ul><li>Class: `MatrixMath`</li><li>Prototype: `public static double[,] Inverse2D(double[,] matrix)`</li><li>Returns `-1` if the matrix is not a 2D matrix or non-invertible</li></ul> |