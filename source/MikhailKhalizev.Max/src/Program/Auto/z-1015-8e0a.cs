using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8e0a-daeebee8")]
        public void Method_1015_8e0a()
        {
            ii(0x1015_8e0a, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_8e0f, 5); call(Definitions.sys_check_available_stack_size, 0xcf3e); /* call 0x10165d52 */
            ii(0x1015_8e14, 1); push(ebx);                              /* push ebx */
            ii(0x1015_8e15, 1); push(ecx);                              /* push ecx */
            ii(0x1015_8e16, 1); push(esi);                              /* push esi */
            ii(0x1015_8e17, 1); push(edi);                              /* push edi */
            ii(0x1015_8e18, 1); push(ebp);                              /* push ebp */
            ii(0x1015_8e19, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8e1b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1015_8e21, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_8e24, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_8e27, 5); mov(eax, 0x1015_7f78);                  /* mov eax, 0x10157f78 */
            ii(0x1015_8e2c, 1); push(eax);                              /* push eax */
            ii(0x1015_8e2d, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1015_8e32, 5); mov(ebx, StringDefinitions.Auto);       /* mov ebx, 0x101b24ff */
            ii(0x1015_8e37, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_8e3a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8e3c, 3); mov(dl, memb[ds, eax + 92]);            /* mov dl, [eax+0x5c] */
            ii(0x1015_8e3f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_8e42, 5); call(0x1015_7ccf, -0x1178);             /* call 0x10157ccf */
            ii(0x1015_8e47, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_8e4a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_8e4d, 5); call(0x1015_8bbb, -0x297);              /* call 0x10158bbb */
            ii(0x1015_8e52, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_8e54, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_8e55, 1); pop(edi);                               /* pop edi */
            ii(0x1015_8e56, 1); pop(esi);                               /* pop esi */
            ii(0x1015_8e57, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_8e58, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_8e59, 1); ret();                                  /* ret */
        }
    }
}
