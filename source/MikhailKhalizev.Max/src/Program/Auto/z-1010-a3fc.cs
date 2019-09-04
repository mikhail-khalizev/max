using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_a3fc-17ccbca1")]
        public void Method_1010_a3fc()
        {
            ii(0x1010_a3fc, 5); push(0x38);                             /* push 0x38 */
            ii(0x1010_a401, 5); call(Definitions.sys_check_available_stack_size, 0x5_b94c); /* call 0x10165d52 */
            ii(0x1010_a406, 1); push(ebx);                              /* push ebx */
            ii(0x1010_a407, 1); push(ecx);                              /* push ecx */
            ii(0x1010_a408, 1); push(edx);                              /* push edx */
            ii(0x1010_a409, 1); push(esi);                              /* push esi */
            ii(0x1010_a40a, 1); push(edi);                              /* push edi */
            ii(0x1010_a40b, 1); push(ebp);                              /* push ebp */
            ii(0x1010_a40c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_a40e, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1010_a414, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_a417, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1010_a41c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_a41f, 5); call(0x1010_a26b, -0x1b9);              /* call 0x1010a26b */
            ii(0x1010_a424, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1010_a429, 5); call(0x1007_5fdc, -0x9_4452);           /* call 0x10075fdc */
            ii(0x1010_a42e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_a431, 5); mov(ebx, 7);                            /* mov ebx, 0x7 */
            ii(0x1010_a436, 5); mov(edx, 6);                            /* mov edx, 0x6 */
            ii(0x1010_a43b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_a43e, 5); call(0x1010_a36e, -0xd5);               /* call 0x1010a36e */
            ii(0x1010_a443, 5); call(0x100d_531c, -0x3_512c);           /* call 0x100d531c */
            ii(0x1010_a448, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_a44d, 1); push(eax);                              /* push eax */
            ii(0x1010_a44e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_a450, 1); push(eax);                              /* push eax */
            ii(0x1010_a451, 5); push(0x1_0004);                         /* push 0x10004 */
            ii(0x1010_a456, 5); mov(eax, 0x3c);                         /* mov eax, 0x3c */
            ii(0x1010_a45b, 1); push(eax);                              /* push eax */
            ii(0x1010_a45c, 5); mov(eax, 0xb4);                         /* mov eax, 0xb4 */
            ii(0x1010_a461, 1); push(eax);                              /* push eax */
            ii(0x1010_a462, 5); mov(eax, 0xaa);                         /* mov eax, 0xaa */
            ii(0x1010_a467, 1); push(eax);                              /* push eax */
            ii(0x1010_a468, 5); mov(ecx, 0x13);                         /* mov ecx, 0x13 */
            ii(0x1010_a46d, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1010_a472, 5); call(0x1007_5fdc, -0x9_449b);           /* call 0x10075fdc */
            ii(0x1010_a477, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_a47a, 6); mov(ebx, memd[ds, eax + 0x101b_af5c]);  /* mov ebx, [eax+0x101baf5c] */
            ii(0x1010_a480, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_a483, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_a485, 3); mov(edx, memd[ds, edx + 14]);           /* mov edx, [edx+0xe] */
            ii(0x1010_a488, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_a48b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_a48e, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_a490, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1010_a493, 5); call(0x100e_9ae5, -0x2_09b3);           /* call 0x100e9ae5 */
            ii(0x1010_a498, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_a49a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_a49b, 1); pop(edi);                               /* pop edi */
            ii(0x1010_a49c, 1); pop(esi);                               /* pop esi */
            ii(0x1010_a49d, 1); pop(edx);                               /* pop edx */
            ii(0x1010_a49e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_a49f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_a4a0, 1); ret();                                  /* ret */
        }
    }
}
