using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6408-5c4b3af9")]
        public void Method_1007_6408()
        {
            ii(0x1007_6408, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_640d, 5); call(Definitions.sys_check_available_stack_size, 0xe_f940); /* call 0x10165d52 */
            ii(0x1007_6412, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6413, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6414, 1); push(edx);                              /* push edx */
            ii(0x1007_6415, 1); push(esi);                              /* push esi */
            ii(0x1007_6416, 1); push(edi);                              /* push edi */
            ii(0x1007_6417, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6418, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_641a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_6420, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_6423, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_6426, 5); call(0x1007_6c30, 0x805);               /* call 0x10076c30 */
            ii(0x1007_642b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_642e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_6431, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6433, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6434, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6435, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6436, 1); pop(edx);                               /* pop edx */
            ii(0x1007_6437, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6438, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6439, 1); ret();                                  /* ret */
        }
    }
}
