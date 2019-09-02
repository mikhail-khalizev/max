using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_4578-4275d03")]
        public void Method_1011_4578()
        {
            ii(0x1011_4578, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_457d, 5); call(Definitions.sys_check_available_stack_size, 0x5_17d0); /* call 0x10165d52 */
            ii(0x1011_4582, 1); push(ebx);                              /* push ebx */
            ii(0x1011_4583, 1); push(ecx);                              /* push ecx */
            ii(0x1011_4584, 1); push(edx);                              /* push edx */
            ii(0x1011_4585, 1); push(esi);                              /* push esi */
            ii(0x1011_4586, 1); push(edi);                              /* push edi */
            ii(0x1011_4587, 1); push(ebp);                              /* push ebp */
            ii(0x1011_4588, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_458a, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1011_4590, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_4593, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_4596, 6); add(edx, 0x3b0);                        /* add edx, 0x3b0 */
            ii(0x1011_459c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_459f, 5); add(eax, 0x1a2);                        /* add eax, 0x1a2 */
            ii(0x1011_45a4, 5); call(Definitions.sys_strcpy, 0x5_1926); /* call 0x10165ecf */
            ii(0x1011_45a9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_45ac, 6); mov(edx, memd[ds, eax + 410]);          /* mov edx, [eax+0x19a] */
            ii(0x1011_45b2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_45b5, 6); mov(memd[ds, eax + 414], edx);          /* mov [eax+0x19e], edx */
            ii(0x1011_45bb, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_45be, 6); add(edx, 0x1a2);                        /* add edx, 0x1a2 */
            ii(0x1011_45c4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_45c7, 6); mov(eax, memd[ds, eax + 414]);          /* mov eax, [eax+0x19e] */
            ii(0x1011_45cd, 5); call(0x100e_b14d, -0x2_9485);           /* call 0x100eb14d */
            ii(0x1011_45d2, 5); call(0x100d_6104, -0x3_e4d3);           /* call 0x100d6104 */
            ii(0x1011_45d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_45d9, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_45db, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_45de, 6); mov(eax, memd[ds, eax + 414]);          /* mov eax, [eax+0x19e] */
            ii(0x1011_45e4, 5); call(0x100e_b5e1, -0x2_9008);           /* call 0x100eb5e1 */
            ii(0x1011_45e9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_45ec, 6); mov(eax, memd[ds, eax + 414]);          /* mov eax, [eax+0x19e] */
            ii(0x1011_45f2, 5); call(0x100e_b1b2, -0x2_9445);           /* call 0x100eb1b2 */
            ii(0x1011_45f7, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1011_45fc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_45ff, 3); mov(eax, memd[ds, eax + 90]);           /* mov eax, [eax+0x5a] */
            ii(0x1011_4602, 5); call(0x100c_fb73, -0x4_4a94);           /* call 0x100cfb73 */
            ii(0x1011_4607, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_4609, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_460a, 1); pop(edi);                               /* pop edi */
            ii(0x1011_460b, 1); pop(esi);                               /* pop esi */
            ii(0x1011_460c, 1); pop(edx);                               /* pop edx */
            ii(0x1011_460d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_460e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_460f, 1); ret();                                  /* ret */
        }
    }
}
