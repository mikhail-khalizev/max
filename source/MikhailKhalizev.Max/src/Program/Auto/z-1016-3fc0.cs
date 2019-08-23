using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3fc0-e8933efa")]
        public void Method_1016_3fc0()
        {
            ii(0x1016_3fc0, 5); push(0x20);                             /* push 0x20 */
            ii(0x1016_3fc5, 5); call(Definitions.sys_check_available_stack_size, 0x1d88); /* call 0x10165d52 */
            ii(0x1016_3fca, 1); push(ebx);                              /* push ebx */
            ii(0x1016_3fcb, 1); push(ecx);                              /* push ecx */
            ii(0x1016_3fcc, 1); push(esi);                              /* push esi */
            ii(0x1016_3fcd, 1); push(edi);                              /* push edi */
            ii(0x1016_3fce, 1); push(ebp);                              /* push ebp */
            ii(0x1016_3fcf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3fd1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_3fd7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_3fda, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_3fdd, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3fe0, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1016_3fe3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3fe6, 5); call(0x1013_bb7b, -0x2_8470);           /* call 0x1013bb7b */
            ii(0x1016_3feb, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3fee, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1016_3ff1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3ff4, 5); call(0x1013_bb7b, -0x2_847e);           /* call 0x1013bb7b */
            ii(0x1016_3ff9, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3ffc, 3); add(edx, 0xc);                          /* add edx, 0xc */
            ii(0x1016_3fff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_4002, 5); call(0x1013_bb7b, -0x2_848c);           /* call 0x1013bb7b */
            ii(0x1016_4007, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_400a, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x1016_400d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_4010, 5); call(0x1013_bb7b, -0x2_849a);           /* call 0x1013bb7b */
            ii(0x1016_4015, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4018, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1016_401b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_401e, 5); call(0x1013_bb7b, -0x2_84a8);           /* call 0x1013bb7b */
            ii(0x1016_4023, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4026, 3); add(edx, 0x12);                         /* add edx, 0x12 */
            ii(0x1016_4029, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_402c, 5); call(0x1013_bb7b, -0x2_84b6);           /* call 0x1013bb7b */
            ii(0x1016_4031, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_4034, 3); add(edx, 0x14);                         /* add edx, 0x14 */
            ii(0x1016_4037, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_403a, 5); call(0x1013_bb7b, -0x2_84c4);           /* call 0x1013bb7b */
            ii(0x1016_403f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4041, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_4042, 1); pop(edi);                               /* pop edi */
            ii(0x1016_4043, 1); pop(esi);                               /* pop esi */
            ii(0x1016_4044, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_4045, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_4046, 1); ret();                                  /* ret */
        }
    }
}
