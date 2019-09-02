using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_c6f6-df0f5892")]
        public void Method_100f_c6f6()
        {
            ii(0x100f_c6f6, 5); push(0x44);                             /* push 0x44 */
            ii(0x100f_c6fb, 5); call(Definitions.sys_check_available_stack_size, 0x6_9652); /* call 0x10165d52 */
            ii(0x100f_c700, 1); push(esi);                              /* push esi */
            ii(0x100f_c701, 1); push(edi);                              /* push edi */
            ii(0x100f_c702, 1); push(ebp);                              /* push ebp */
            ii(0x100f_c703, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_c705, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100f_c70b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100f_c70e, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100f_c711, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100f_c714, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100f_c717, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c71a, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100f_c71d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100f_c720, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100f_c723, 1); inc(ebx);                               /* inc ebx */
            ii(0x100f_c724, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x100f_c726, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_c728, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_c72a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_c72d, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_c72f, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100f_c731, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_c733, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100f_c736, 3); movsx(edx, memw[ds, edx]);              /* movsx edx, word [edx] */
            ii(0x100f_c739, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_c73b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c73e, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x100f_c741, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100f_c744, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x100f_c746, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c749, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100f_c74c, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100f_c74e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_c751, 1); inc(eax);                               /* inc eax */
            ii(0x100f_c752, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_c754, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_c756, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_c758, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_c75b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_c75d, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100f_c75f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_c761, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_c763, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100f_c766, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x100f_c768, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c76b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100f_c76d, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100f_c770, 4); mov(memw[ds, edx + 2], ax);             /* mov [edx+0x2], ax */
            ii(0x100f_c774, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c777, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100f_c77b, 3); sub(eax, 4);                            /* sub eax, 0x4 */
            ii(0x100f_c77e, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_c781, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100f_c785, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c787, 2); if(jge(0x100f_c790, 7)) goto l_0x100f_c790; /* jge 0x100fc790 */
            ii(0x100f_c789, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
        l_0x100f_c790:
            ii(0x100f_c790, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x100f_c794, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_c796, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_c799, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_c79b, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100f_c79d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_c79f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_c7a1, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100f_c7a4, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_c7a6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c7a9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_c7ab, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_c7ae, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c7b1, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_c7b4, 3); sub(eax, 4);                            /* sub eax, 0x4 */
            ii(0x100f_c7b7, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100f_c7ba, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100f_c7be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c7c0, 2); if(jge(0x100f_c7c9, 7)) goto l_0x100f_c7c9; /* jge 0x100fc7c9 */
            ii(0x100f_c7c2, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
        l_0x100f_c7c9:
            ii(0x100f_c7c9, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x100f_c7cd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_c7cf, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_c7d2, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_c7d4, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100f_c7d6, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_c7d8, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_c7da, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100f_c7dd, 3); movsx(eax, memw[ds, edx]);              /* movsx eax, word [edx] */
            ii(0x100f_c7e0, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100f_c7e2, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100f_c7e5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c7e8, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100f_c7ec, 5); add(eax, 5);                            /* add eax, 0x5 */
            ii(0x100f_c7f1, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100f_c7f4, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100f_c7f7, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100f_c7fe, 2); if(jle(0x100f_c809, 9)) goto l_0x100f_c809; /* jle 0x100fc809 */
            ii(0x100f_c800, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x100f_c806, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
        l_0x100f_c809:
            ii(0x100f_c809, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c80c, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_c80f, 5); add(eax, 5);                            /* add eax, 0x5 */
            ii(0x100f_c814, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100f_c817, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100f_c81a, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100f_c821, 2); if(jle(0x100f_c82c, 9)) goto l_0x100f_c82c; /* jle 0x100fc82c */
            ii(0x100f_c823, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x100f_c829, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x100f_c82c:
            ii(0x100f_c82c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c82f, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100f_c831, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_c834, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100f_c839, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c83c, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100f_c83f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c842, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_c845, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_c847, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_c849, 6); mov(edx, memd[ds, 0x101c_811c]);        /* mov edx, [0x101c811c] */
            ii(0x100f_c84f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_c851, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_c854, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x100f_c859, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100f_c85c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c85f, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_c862, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c864, 2); if(jle(0x100f_c8d0, 0x6a)) goto l_0x100f_c8d0; /* jle 0x100fc8d0 */
            ii(0x100f_c866, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c869, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_c86b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c86e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c870, 2); if(jle(0x100f_c89a, 0x28)) goto l_0x100f_c89a; /* jle 0x100fc89a */
            ii(0x100f_c872, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_c875, 3); add(eax, memd[ss, ebp - 36]);           /* add eax, [ebp-0x24] */
            ii(0x100f_c878, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_c87b, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_c87f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c882, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100f_c886, 1); dec(eax);                               /* dec eax */
            ii(0x100f_c887, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_c88a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c88d, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_c890, 1); dec(eax);                               /* dec eax */
            ii(0x100f_c891, 1); cwde();                                 /* cwde */
            ii(0x100f_c892, 5); call(0x100f_c68c, -0x20b);              /* call 0x100fc68c */
            ii(0x100f_c897, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100f_c89a:
            ii(0x100f_c89a, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100f_c89f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c8a2, 4); movsx(edx, memw[ss, ebp - 40]);         /* movsx edx, word [ebp-0x28] */
            ii(0x100f_c8a6, 1); dec(eax);                               /* dec eax */
            ii(0x100f_c8a7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_c8a9, 2); if(jge(0x100f_c8d0, 0x25)) goto l_0x100f_c8d0; /* jge 0x100fc8d0 */
            ii(0x100f_c8ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_c8ae, 3); add(eax, memd[ss, ebp - 36]);           /* add eax, [ebp-0x24] */
            ii(0x100f_c8b1, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_c8b4, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_c8b8, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c8bb, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100f_c8bd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_c8c0, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c8c3, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_c8c6, 1); dec(eax);                               /* dec eax */
            ii(0x100f_c8c7, 1); cwde();                                 /* cwde */
            ii(0x100f_c8c8, 5); call(0x100f_c68c, -0x241);              /* call 0x100fc68c */
            ii(0x100f_c8cd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100f_c8d0:
            ii(0x100f_c8d0, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x100f_c8d6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_c8d9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c8dc, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_c8df, 1); dec(edx);                               /* dec edx */
            ii(0x100f_c8e0, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_c8e2, 2); if(jge(0x100f_c94e, 0x6a)) goto l_0x100f_c94e; /* jge 0x100fc94e */
            ii(0x100f_c8e4, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c8e7, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_c8e9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c8ec, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c8ee, 2); if(jle(0x100f_c916, 0x26)) goto l_0x100f_c916; /* jle 0x100fc916 */
            ii(0x100f_c8f0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_c8f3, 3); add(eax, memd[ss, ebp - 36]);           /* add eax, [ebp-0x24] */
            ii(0x100f_c8f6, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_c8f9, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_c8fd, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c900, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100f_c904, 1); dec(eax);                               /* dec eax */
            ii(0x100f_c905, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_c908, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c90b, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_c90e, 5); call(0x100f_c68c, -0x287);              /* call 0x100fc68c */
            ii(0x100f_c913, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100f_c916:
            ii(0x100f_c916, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c919, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100f_c91b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_c91e, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100f_c923, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c926, 1); dec(eax);                               /* dec eax */
            ii(0x100f_c927, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_c929, 2); if(jge(0x100f_c94e, 0x23)) goto l_0x100f_c94e; /* jge 0x100fc94e */
            ii(0x100f_c92b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_c92e, 3); add(eax, memd[ss, ebp - 36]);           /* add eax, [ebp-0x24] */
            ii(0x100f_c931, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_c934, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_c938, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c93b, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100f_c93d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_c940, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c943, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_c946, 5); call(0x100f_c68c, -0x2bf);              /* call 0x100fc68c */
            ii(0x100f_c94b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100f_c94e:
            ii(0x100f_c94e, 4); imul(eax, memd[ss, ebp - 8], 0x64);     /* imul eax, [ebp-0x8], 0x64 */
            ii(0x100f_c952, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_c955, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_c958, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100f_c95b, 2); jmp(0x100f_c961, 4); goto l_0x100f_c961; /* jmp 0x100fc961 */
        l_0x100f_c95d:
            ii(0x100f_c95d, 4); add(memd[ss, ebp - 44], 2);             /* add dword [ebp-0x2c], 0x2 */
        l_0x100f_c961:
            ii(0x100f_c961, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100f_c964, 4); cmp(ax, memw[ss, ebp - 32]);            /* cmp ax, [ebp-0x20] */
            ii(0x100f_c968, 6); if(jge(0x100f_ca49, 0xdb)) goto l_0x100f_ca49; /* jge 0x100fca49 */
            ii(0x100f_c96e, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_c971, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100f_c974, 2); jmp(0x100f_c97a, 4); goto l_0x100f_c97a; /* jmp 0x100fc97a */
        l_0x100f_c976:
            ii(0x100f_c976, 4); add(memd[ss, ebp - 40], 2);             /* add dword [ebp-0x28], 0x2 */
        l_0x100f_c97a:
            ii(0x100f_c97a, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100f_c97d, 4); cmp(ax, memw[ss, ebp - 28]);            /* cmp ax, [ebp-0x1c] */
            ii(0x100f_c981, 6); if(jge(0x100f_ca44, 0xbd)) goto l_0x100f_ca44; /* jge 0x100fca44 */
            ii(0x100f_c987, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100f_c98a, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100f_c98e, 3); sub(eax, memd[ss, ebp - 40]);           /* sub eax, [ebp-0x28] */
            ii(0x100f_c991, 1); cwde();                                 /* cwde */
            ii(0x100f_c992, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100f_c995, 3); mov(dx, memw[ds, edx]);                 /* mov dx, [edx] */
            ii(0x100f_c998, 3); sub(edx, memd[ss, ebp - 44]);           /* sub edx, [ebp-0x2c] */
            ii(0x100f_c99b, 3); movsx(ebx, dx);                         /* movsx ebx, dx */
            ii(0x100f_c99e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_c9a0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_c9a2, 5); call(0x100a_5f65, -0x5_6a42);           /* call 0x100a5f65 */
            ii(0x100f_c9a7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_c9aa, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x100f_c9ad, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100f_c9b0, 3); mov(ebx, memd[ds, eax + 16]);           /* mov ebx, [eax+0x10] */
            ii(0x100f_c9b3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_c9b6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_c9b8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_c9bb, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_c9bd, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100f_c9c0, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100f_c9c3, 4); movsx(edx, memw[ss, ebp - 48]);         /* movsx edx, word [ebp-0x30] */
            ii(0x100f_c9c7, 4); movsx(eax, memw[ss, ebp - 48]);         /* movsx eax, word [ebp-0x30] */
            ii(0x100f_c9cb, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100f_c9ce, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100f_c9d0, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100f_c9d4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_c9d6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_c9d9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_c9db, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100f_c9de, 4); movsx(edx, memw[ss, ebp - 40]);         /* movsx edx, word [ebp-0x28] */
            ii(0x100f_c9e2, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100f_c9e7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_c9ea, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_c9ed, 4); movsx(edx, memw[ss, ebp - 44]);         /* movsx edx, word [ebp-0x2c] */
            ii(0x100f_c9f1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_c9f3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_c9f5, 6); mov(edx, memd[ds, 0x101c_811c]);        /* mov edx, [0x101c811c] */
            ii(0x100f_c9fb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_c9fd, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_ca00, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x100f_ca05, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100f_ca0a, 4); movsx(edx, memw[ss, ebp - 52]);         /* movsx edx, word [ebp-0x34] */
            ii(0x100f_ca0e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_ca10, 2); if(jle(0x100f_ca3f, 0x2d)) goto l_0x100f_ca3f; /* jle 0x100fca3f */
            ii(0x100f_ca12, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100f_ca15, 4); mov(bx, memw[ds, eax + 4]);             /* mov bx, [eax+0x4] */
            ii(0x100f_ca19, 3); add(ebx, memd[ss, ebp - 52]);           /* add ebx, [ebp-0x34] */
            ii(0x100f_ca1c, 4); movsx(eax, memw[ss, ebp - 40]);         /* movsx eax, word [ebp-0x28] */
            ii(0x100f_ca20, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x100f_ca26, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_ca29, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_ca2c, 4); movsx(edx, memw[ss, ebp - 44]);         /* movsx edx, word [ebp-0x2c] */
            ii(0x100f_ca30, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_ca32, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_ca34, 6); mov(edx, memd[ds, 0x101c_811c]);        /* mov edx, [0x101c811c] */
            ii(0x100f_ca3a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_ca3c, 3); mov(memw[ds, eax], bx);                 /* mov [eax], bx */
        l_0x100f_ca3f:
            ii(0x100f_ca3f, 5); jmp(0x100f_c976, -0xce); goto l_0x100f_c976; /* jmp 0x100fc976 */
        l_0x100f_ca44:
            ii(0x100f_ca44, 5); jmp(0x100f_c95d, -0xec); goto l_0x100f_c95d; /* jmp 0x100fc95d */
        l_0x100f_ca49:
            ii(0x100f_ca49, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_ca4b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_ca4c, 1); pop(edi);                               /* pop edi */
            ii(0x100f_ca4d, 1); pop(esi);                               /* pop esi */
            ii(0x100f_ca4e, 1); ret();                                  /* ret */
        }
    }
}
