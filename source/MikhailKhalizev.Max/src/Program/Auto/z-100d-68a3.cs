using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_68a3-8c3c09c4")]
        public void Method_100d_68a3()
        {
            ii(0x100d_68a3, 5); push(0x334);                            /* push 0x334 */
            ii(0x100d_68a8, 5); call(Definitions.sys_check_available_stack_size, 0x8_f4a5); /* call 0x10165d52 */
            ii(0x100d_68ad, 1); push(ecx);                              /* push ecx */
            ii(0x100d_68ae, 1); push(esi);                              /* push esi */
            ii(0x100d_68af, 1); push(edi);                              /* push edi */
            ii(0x100d_68b0, 1); push(ebp);                              /* push ebp */
            ii(0x100d_68b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_68b3, 6); sub(esp, 0x320);                        /* sub esp, 0x320 */
            ii(0x100d_68b9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_68bc, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_68bf, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100d_68c2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_68c5, 7); mov(memd[ds, eax + 0x13], 0x101b_5f98); /* mov dword [eax+0x13], 0x101b5f98 */
            ii(0x100d_68cc, 4); movsx(eax, memb[ss, ebp - 0x4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x100d_68d0, 5); call(0x100e_883d, 0x1_1f68);            /* call 0x100e883d */
            ii(0x100d_68d5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_68d8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_68db, 6); mov(memd[ds, eax], 0);                  /* mov dword [eax], 0x0 */
            ii(0x100d_68e1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_68e4, 7); mov(memd[ds, eax + 0xc], 0);            /* mov dword [eax+0xc], 0x0 */
            ii(0x100d_68eb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_68ee, 4); mov(memb[ds, eax + 0x12], 0);           /* mov byte [eax+0x12], 0x0 */
            ii(0x100d_68f2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_68f5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_68f8, 4); mov(memw[ds, edx + 0x10], ax);          /* mov [edx+0x10], ax */
            ii(0x100d_68fc, 6); lea(edx, memd[ss, ebp - 0x31c]);        /* lea edx, [ebp-0x31c] */
            ii(0x100d_6902, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_6906, 5); call(0x1013_45c2, 0x5_dcb7);            /* call 0x101345c2 */
            ii(0x100d_690b, 6); mov(eax, memd[ss, ebp - 0x318]);        /* mov eax, [ebp-0x318] */
            ii(0x100d_6911, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_6914, 4); mov(memw[ds, edx + 0x8], ax);           /* mov [edx+0x8], ax */
            ii(0x100d_6918, 6); mov(eax, memd[ss, ebp - 0x316]);        /* mov eax, [ebp-0x316] */
            ii(0x100d_691e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_6921, 4); mov(memw[ds, edx + 0xa], ax);           /* mov [edx+0xa], ax */
            ii(0x100d_6925, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6928, 3); mov(edx, memd[ds, edx + 0x8]);          /* mov edx, [edx+0x8] */
            ii(0x100d_692b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_692e, 2); sub(edx, memd[ds, eax]);                /* sub edx, [eax] */
            ii(0x100d_6930, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_6933, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_6936, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_6939, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_693b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_693d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_6940, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_6942, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_6944, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_6946, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6949, 2); add(edx, memd[ds, eax]);                /* add edx, [eax] */
            ii(0x100d_694b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_694e, 4); mov(memw[ds, eax + 0x4], dx);           /* mov [eax+0x4], dx */
            ii(0x100d_6952, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6955, 3); mov(edx, memd[ds, edx + 0xc]);          /* mov edx, [edx+0xc] */
            ii(0x100d_6958, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_695b, 3); sub(edx, memd[ds, eax + 0x4]);          /* sub edx, [eax+0x4] */
            ii(0x100d_695e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_6960, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_6963, 3); mov(edx, memd[ds, edx + 0x8]);          /* mov edx, [edx+0x8] */
            ii(0x100d_6966, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_6969, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_696b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_696d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_696f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_6972, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_6974, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_6976, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6979, 3); add(eax, memd[ds, edx + 0x4]);          /* add eax, [edx+0x4] */
            ii(0x100d_697c, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_697f, 4); mov(memw[ds, edx + 0x6], ax);           /* mov [edx+0x6], ax */
            ii(0x100d_6983, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_6986, 6); mov(memd[ss, ebp - 0x320], eax);        /* mov [ebp-0x320], eax */
            ii(0x100d_698c, 6); mov(eax, memd[ss, ebp - 0x320]);        /* mov eax, [ebp-0x320] */
            ii(0x100d_6992, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6994, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_6995, 1); pop(edi);                               /* pop edi */
            ii(0x100d_6996, 1); pop(esi);                               /* pop esi */
            ii(0x100d_6997, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_6998, 1); ret();                                  /* ret */
        }
    }
}
