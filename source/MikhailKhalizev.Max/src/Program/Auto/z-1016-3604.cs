using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3604-2f734558")]
        public void Method_1016_3604()
        {
            ii(0x1016_3604, 5); push(0x20);                             /* push 0x20 */
            ii(0x1016_3609, 5); call(Definitions.sys_check_available_stack_size, 0x2744); /* call 0x10165d52 */
            ii(0x1016_360e, 1); push(ebx);                              /* push ebx */
            ii(0x1016_360f, 1); push(ecx);                              /* push ecx */
            ii(0x1016_3610, 1); push(esi);                              /* push esi */
            ii(0x1016_3611, 1); push(edi);                              /* push edi */
            ii(0x1016_3612, 1); push(ebp);                              /* push ebp */
            ii(0x1016_3613, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_3615, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_361b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_361e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_3621, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3624, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1016_3627, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_362a, 5); call(0x1013_bb7b, -0x2_7ab4);           /* call 0x1013bb7b */
            ii(0x1016_362f, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3632, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1016_3635, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3638, 5); call(0x1013_bb7b, -0x2_7ac2);           /* call 0x1013bb7b */
            ii(0x1016_363d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3640, 3); add(edx, 0xc);                          /* add edx, 0xc */
            ii(0x1016_3643, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3646, 5); call(0x1013_bb7b, -0x2_7ad0);           /* call 0x1013bb7b */
            ii(0x1016_364b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_364e, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x1016_3651, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3654, 5); call(0x1013_bb7b, -0x2_7ade);           /* call 0x1013bb7b */
            ii(0x1016_3659, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_365c, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1016_365f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3662, 5); call(0x1013_bb7b, -0x2_7aec);           /* call 0x1013bb7b */
            ii(0x1016_3667, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_366a, 3); add(edx, 0x12);                         /* add edx, 0x12 */
            ii(0x1016_366d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_3670, 5); call(0x1013_bb7b, -0x2_7afa);           /* call 0x1013bb7b */
            ii(0x1016_3675, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3678, 3); add(edx, 0x14);                         /* add edx, 0x14 */
            ii(0x1016_367b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_367e, 5); call(0x1013_bb7b, -0x2_7b08);           /* call 0x1013bb7b */
            ii(0x1016_3683, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3686, 3); add(edx, 0x16);                         /* add edx, 0x16 */
            ii(0x1016_3689, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_368c, 5); call(0x1013_bb11, -0x2_7b80);           /* call 0x1013bb11 */
            ii(0x1016_3691, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_3694, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1016_3697, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_369a, 5); call(0x1013_bb7b, -0x2_7b24);           /* call 0x1013bb7b */
            ii(0x1016_369f, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_36a2, 3); add(edx, 0x19);                         /* add edx, 0x19 */
            ii(0x1016_36a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_36a8, 5); call(0x1013_bb7b, -0x2_7b32);           /* call 0x1013bb7b */
            ii(0x1016_36ad, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_36b0, 3); add(edx, 0x1b);                         /* add edx, 0x1b */
            ii(0x1016_36b3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_36b6, 5); call(0x1013_bb7b, -0x2_7b40);           /* call 0x1013bb7b */
            ii(0x1016_36bb, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_36be, 3); add(edx, 0x1d);                         /* add edx, 0x1d */
            ii(0x1016_36c1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_36c4, 5); call(0x1013_bb7b, -0x2_7b4e);           /* call 0x1013bb7b */
            ii(0x1016_36c9, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_36cc, 3); add(edx, 0x1f);                         /* add edx, 0x1f */
            ii(0x1016_36cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_36d2, 5); call(0x1013_bb7b, -0x2_7b5c);           /* call 0x1013bb7b */
            ii(0x1016_36d7, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_36da, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1016_36dd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_36e0, 5); call(0x1013_bb7b, -0x2_7b6a);           /* call 0x1013bb7b */
            ii(0x1016_36e5, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_36e8, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_36eb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_36ee, 5); call(0x1013_bb11, -0x2_7be2);           /* call 0x1013bb11 */
            ii(0x1016_36f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_36f5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_36f6, 1); pop(edi);                               /* pop edi */
            ii(0x1016_36f7, 1); pop(esi);                               /* pop esi */
            ii(0x1016_36f8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_36f9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_36fa, 1); ret();                                  /* ret */
        }
    }
}
