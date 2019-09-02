using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1002-50d68e92")]
        public void /* sys */ Method_1018_1002()
        {
            ii(0x1018_1002, 1); push(ebx);                              /* push ebx */
            ii(0x1018_1003, 1); push(ecx);                              /* push ecx */
            ii(0x1018_1004, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_1006, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_1008, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1018_100a, 5); call(/* sys */ 0x1019_5b64, 0x1_4b55);  /* call 0x10195b64 */
            ii(0x1018_100f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_1011, 2); if(jnz(0x1018_101c, 9)) goto l_0x1018_101c; /* jnz 0x1018101c */
            ii(0x1018_1013, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1018_1015, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_1017, 5); call(/* sys */ 0x1016_c995, -0x1_4687); /* call 0x1016c995 */
        l_0x1018_101c:
            ii(0x1018_101c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_101d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_101e, 1); ret();                                  /* ret */
        }
    }
}
