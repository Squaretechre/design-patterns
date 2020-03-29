package structural.decorator.inputstream;

import java.io.*;

public class InputTest {

    public static void main(String[] args) throws IOException  {
        int c;

        String workingDir = System.getProperty("user.dir");
        System.out.println(workingDir + "/src/structural/decorator/inputstream/test.txt");

        try {
            InputStream in =
                    new LowerCaseInputStream(
                            new BufferedInputStream(
                                    new FileInputStream(workingDir + "/src/structural/decorator/inputstream/test.txt")
                            )
                    );

            while((c = in.read()) >= 0) {
                System.out.print((char) c);
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }
}
