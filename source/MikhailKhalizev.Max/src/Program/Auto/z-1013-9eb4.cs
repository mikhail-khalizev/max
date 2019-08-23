using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9eb4-51a272cf")]
        public void Method_1013_9eb4()
        {
            ii(0x1013_9eb4, 5); push(0x34);                             /* push 0x34 */
            ii(0x1013_9eb9, 5); call(Definitions.sys_check_available_stack_size, 0x2_be94); /* call 0x10165d52 */
            ii(0x1013_9ebe, 1); push(ebx);                              /* push ebx */
            ii(0x1013_9ebf, 1); push(ecx);                              /* push ecx */
            ii(0x1013_9ec0, 1); push(esi);                              /* push esi */
            ii(0x1013_9ec1, 1); push(edi);                              /* push edi */
            ii(0x1013_9ec2, 1); push(ebp);                              /* push ebp */
            ii(0x1013_9ec3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9ec5, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1013_9ecb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_9ece, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_9ed1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_9ed4, 5); call(0x1013_aaa8, 0xbcf);               /* call 0x1013aaa8 */
            ii(0x1013_9ed9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_9edc, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_9edf, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_9ee2, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_9ee5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_9ee8, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_9eeb, 5); call(0x1013_abc3, 0xcd3);               /* call 0x1013abc3 */
            ii(0x1013_9ef0, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1013_9ef3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_9ef6, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_9ef9, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_9efc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_9eff, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_9f02, 5); call(0x1007_6d58, -0xc_31af);           /* call 0x10076d58 */
            ii(0x1013_9f07, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1013_9f0a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_9f0d, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_9f10, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_9f13, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_9f16, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_9f19, 5); call(0x1007_6d58, -0xc_31c6);           /* call 0x10076d58 */
            ii(0x1013_9f1e, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1013_9f21, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_9f24, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_9f27, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_9f2a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_9f2d, 7); mov(memd[ds, eax + 0x2], 0x101b_6eac);  /* mov dword [eax+0x2], 0x101b6eac */
            ii(0x1013_9f34, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_9f37, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_9f3a, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_9f3d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9f3f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_9f40, 1); pop(edi);                               /* pop edi */
            ii(0x1013_9f41, 1); pop(esi);                               /* pop esi */
            ii(0x1013_9f42, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_9f43, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_9f44, 1); ret();                                  /* ret */
        }
    }
}
