using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d6bb-abdcc8e4")]
        public void Method_1007_d6bb()
        {
            ii(0x1007_d6bb, 5); push(0x48);                             /* push 0x48 */
            ii(0x1007_d6c0, 5); call(Definitions.sys_check_available_stack_size, 0xe_868d); /* call 0x10165d52 */
            ii(0x1007_d6c5, 1); push(esi);                              /* push esi */
            ii(0x1007_d6c6, 1); push(edi);                              /* push edi */
            ii(0x1007_d6c7, 1); push(ebp);                              /* push ebp */
            ii(0x1007_d6c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_d6ca, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1007_d6d0, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_d6d3, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_d6d6, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1007_d6d9, 3); mov(memd[ss, ebp - 12], ecx);           /* mov [ebp-0xc], ecx */
            ii(0x1007_d6dc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_d6df, 5); call(0x1008_ad90, 0xd6ac);              /* call 0x1008ad90 */
            ii(0x1007_d6e4, 1); cwde();                                 /* cwde */
            ii(0x1007_d6e5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_d6eb, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1007_d6f1, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1007_d6f4, 7); mov(memd[ss, ebp - 32], 0);             /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_d6fb, 5); call(0x100a_314c, 0x2_5a4c);            /* call 0x100a314c */
            ii(0x1007_d700, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1007_d703, 4); or(memb[ss, ebp - 20], 1);              /* or byte [ebp-0x14], 0x1 */
            ii(0x1007_d707, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1007_d70c, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1007_d70f, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1007_d712, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d715, 5); call(0x100b_8505, 0x3_adeb);            /* call 0x100b8505 */
            ii(0x1007_d71a, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1007_d71d, 4); and(memb[ss, ebp - 20], -2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1007_d721, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d724, 5); call(0x1008_a4a0, 0xcd77);              /* call 0x1008a4a0 */
            ii(0x1007_d729, 1); cwde();                                 /* cwde */
            ii(0x1007_d72a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_d72c, 2); if(jnz(0x1007_d73d, 0xf)) goto l_0x1007_d73d; /* jnz 0x1007d73d */
            ii(0x1007_d72e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_d730, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d733, 5); call(0x1008_8dcc, 0xb694);              /* call 0x10088dcc */
            ii(0x1007_d738, 5); jmp(0x1007_d946, 0x209); goto l_0x1007_d946; /* jmp 0x1007d946 */
        l_0x1007_d73d:
            ii(0x1007_d73d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_d740, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1007_d743, 4); mov(memw[ds, edx + 20], ax);            /* mov [edx+0x14], ax */
            ii(0x1007_d747, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_d74e, 2); jmp(0x1007_d756, 6); goto l_0x1007_d756; /* jmp 0x1007d756 */
        l_0x1007_d750:
            ii(0x1007_d750, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1007_d753, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x1007_d756:
            ii(0x1007_d756, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d759, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1007_d75c, 5); call(Definitions.my_2_get_count, 0xdc07); /* call 0x1008b368 */
            ii(0x1007_d761, 4); cmp(ax, memw[ss, ebp - 24]);            /* cmp ax, [ebp-0x18] */
            ii(0x1007_d765, 2); if(jle(0x1007_d790, 0x29)) goto l_0x1007_d790; /* jle 0x1007d790 */
            ii(0x1007_d767, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_d76a, 5); call(0x1008_ad90, 0xd621);              /* call 0x1008ad90 */
            ii(0x1007_d76f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1007_d772, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_d776, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d779, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1007_d77c, 5); call(0x1008_b228, 0xdaa7);              /* call 0x1008b228 */
            ii(0x1007_d781, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1007_d784, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1007_d786, 5); call(0x100a_23e4, 0x2_4c59);            /* call 0x100a23e4 */
            ii(0x1007_d78b, 3); add(memd[ss, ebp - 32], eax);           /* add [ebp-0x20], eax */
            ii(0x1007_d78e, 2); jmp(0x1007_d750, -0x40); goto l_0x1007_d750; /* jmp 0x1007d750 */
        l_0x1007_d790:
            ii(0x1007_d790, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_d797, 2); jmp(0x1007_d79f, 6); goto l_0x1007_d79f; /* jmp 0x1007d79f */
        l_0x1007_d799:
            ii(0x1007_d799, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1007_d79c, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x1007_d79f:
            ii(0x1007_d79f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d7a2, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1007_d7a5, 5); call(0x1008_a4a0, 0xccf6);              /* call 0x1008a4a0 */
            ii(0x1007_d7aa, 4); cmp(ax, memw[ss, ebp - 24]);            /* cmp ax, [ebp-0x18] */
            ii(0x1007_d7ae, 6); if(jle(0x1007_d847, 0x93)) goto l_0x1007_d847; /* jle 0x1007d847 */
            ii(0x1007_d7b4, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_d7b8, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d7bb, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1007_d7be, 5); call(0x1008_a3dc, 0xcc19);              /* call 0x1008a3dc */
            ii(0x1007_d7c3, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1007_d7c6, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1007_d7c9, 5); call(0x1008_b104, 0xd936);              /* call 0x1008b104 */
            ii(0x1007_d7ce, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x1007_d7d1, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1007_d7d4, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1007_d7d8, 4); cmp(ax, memw[ss, ebp - 40]);            /* cmp ax, [ebp-0x28] */
            ii(0x1007_d7dc, 2); if(jg(0x1007_d7eb, 0xd)) goto l_0x1007_d7eb; /* jg 0x1007d7eb */
            ii(0x1007_d7de, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1007_d7e1, 3); mov(eax, memd[ds, eax + 14]);           /* mov eax, [eax+0xe] */
            ii(0x1007_d7e4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_d7e7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_d7e9, 2); if(jnz(0x1007_d7ed, 2)) goto l_0x1007_d7ed; /* jnz 0x1007d7ed */
        l_0x1007_d7eb:
            ii(0x1007_d7eb, 2); jmp(0x1007_d80b, 0x1e); goto l_0x1007_d80b; /* jmp 0x1007d80b */
        l_0x1007_d7ed:
            ii(0x1007_d7ed, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_d7f1, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d7f4, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1007_d7f7, 5); call(0x1008_a3dc, 0xcbe0);              /* call 0x1008a3dc */
            ii(0x1007_d7fc, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1007_d7ff, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_d802, 7); test(memb[ds, eax + 0x101c_81c3], 0x10); /* test byte [eax+0x101c81c3], 0x10 */
            ii(0x1007_d809, 2); if(jz(0x1007_d80d, 2)) goto l_0x1007_d80d; /* jz 0x1007d80d */
        l_0x1007_d80b:
            ii(0x1007_d80b, 2); jmp(0x1007_d830, 0x23); goto l_0x1007_d830; /* jmp 0x1007d830 */
        l_0x1007_d80d:
            ii(0x1007_d80d, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_d811, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d814, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1007_d817, 5); call(0x1008_a3dc, 0xcbc0);              /* call 0x1008a3dc */
            ii(0x1007_d81c, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1007_d81f, 5); call(0x100c_defa, 0x5_06d6);            /* call 0x100cdefa */
            ii(0x1007_d824, 1); cwde();                                 /* cwde */
            ii(0x1007_d825, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_d827, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1007_d82a, 4); cmp(memw[ds, eax], 0);                  /* cmp word [eax], 0x0 */
            ii(0x1007_d82e, 2); if(jnz(0x1007_d842, 0x12)) goto l_0x1007_d842; /* jnz 0x1007d842 */
        l_0x1007_d830:
            ii(0x1007_d830, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_d834, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d837, 5); call(0x1008_a3dc, 0xcba0);              /* call 0x1008a3dc */
            ii(0x1007_d83c, 6); mov(memw[ds, eax + 2], 0);              /* mov word [eax+0x2], 0x0 */
        l_0x1007_d842:
            ii(0x1007_d842, 5); jmp(0x1007_d799, -0xae); goto l_0x1007_d799; /* jmp 0x1007d799 */
        l_0x1007_d847:
            ii(0x1007_d847, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d84a, 3); mov(edx, memd[ds, eax + 16]);           /* mov edx, [eax+0x10] */
            ii(0x1007_d84d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_d850, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x1007_d854, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_d856, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d859, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1007_d85c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_d85f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_d861, 6); if(jge(0x1007_d93c, 0xd5)) goto l_0x1007_d93c; /* jge 0x1007d93c */
            ii(0x1007_d867, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d86a, 5); call(0x100b_870a, 0x3_ae9b);            /* call 0x100b870a */
            ii(0x1007_d86f, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x1007_d872, 5); cmp(memw[ss, ebp - 56], -1 /* 0xff */); /* cmp word [ebp-0x38], 0xffff */
            ii(0x1007_d877, 2); if(jnz(0x1007_d888, 0xf)) goto l_0x1007_d888; /* jnz 0x1007d888 */
            ii(0x1007_d879, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_d87b, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d87e, 5); call(0x1008_8dcc, 0xb549);              /* call 0x10088dcc */
            ii(0x1007_d883, 5); jmp(0x1007_d946, 0xbe); goto l_0x1007_d946; /* jmp 0x1007d946 */
        l_0x1007_d888:
            ii(0x1007_d888, 4); movsx(eax, memw[ss, ebp - 56]);         /* movsx eax, word [ebp-0x38] */
            ii(0x1007_d88c, 5); call(0x100c_defa, 0x5_0669);            /* call 0x100cdefa */
            ii(0x1007_d891, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1007_d894, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_d898, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_d89a, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1007_d89d, 3); dec(memw[ds, eax]);                     /* dec word [eax] */
            ii(0x1007_d8a0, 4); cmp(memw[ds, eax], 0);                  /* cmp word [eax], 0x0 */
            ii(0x1007_d8a4, 2); if(jnz(0x1007_d906, 0x60)) goto l_0x1007_d906; /* jnz 0x1007d906 */
            ii(0x1007_d8a6, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_d8ad, 2); jmp(0x1007_d8b5, 6); goto l_0x1007_d8b5; /* jmp 0x1007d8b5 */
        l_0x1007_d8af:
            ii(0x1007_d8af, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1007_d8b2, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x1007_d8b5:
            ii(0x1007_d8b5, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d8b8, 5); call(0x1008_a4a0, 0xcbe3);              /* call 0x1008a4a0 */
            ii(0x1007_d8bd, 4); cmp(ax, memw[ss, ebp - 24]);            /* cmp ax, [ebp-0x18] */
            ii(0x1007_d8c1, 2); if(jle(0x1007_d906, 0x43)) goto l_0x1007_d906; /* jle 0x1007d906 */
            ii(0x1007_d8c3, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_d8c7, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d8ca, 5); call(0x1008_a3dc, 0xcb0d);              /* call 0x1008a3dc */
            ii(0x1007_d8cf, 5); cmp(memw[ds, eax + 2], 0);              /* cmp word [eax+0x2], 0x0 */
            ii(0x1007_d8d4, 2); if(jz(0x1007_d8f0, 0x1a)) goto l_0x1007_d8f0; /* jz 0x1007d8f0 */
            ii(0x1007_d8d6, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_d8da, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d8dd, 5); call(0x1008_a3dc, 0xcafa);              /* call 0x1008a3dc */
            ii(0x1007_d8e2, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1007_d8e5, 5); call(0x100c_defa, 0x5_0610);            /* call 0x100cdefa */
            ii(0x1007_d8ea, 4); cmp(ax, memw[ss, ebp - 28]);            /* cmp ax, [ebp-0x1c] */
            ii(0x1007_d8ee, 2); if(jz(0x1007_d8f2, 2)) goto l_0x1007_d8f2; /* jz 0x1007d8f2 */
        l_0x1007_d8f0:
            ii(0x1007_d8f0, 2); jmp(0x1007_d904, 0x12); goto l_0x1007_d904; /* jmp 0x1007d904 */
        l_0x1007_d8f2:
            ii(0x1007_d8f2, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_d8f6, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d8f9, 5); call(0x1008_a3dc, 0xcade);              /* call 0x1008a3dc */
            ii(0x1007_d8fe, 6); mov(memw[ds, eax + 2], 0);              /* mov word [eax+0x2], 0x0 */
        l_0x1007_d904:
            ii(0x1007_d904, 2); jmp(0x1007_d8af, -0x57); goto l_0x1007_d8af; /* jmp 0x1007d8af */
        l_0x1007_d906:
            ii(0x1007_d906, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_d909, 5); call(0x1008_ad90, 0xd482);              /* call 0x1008ad90 */
            ii(0x1007_d90e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_d911, 4); movsx(eax, memw[ss, ebp - 56]);         /* movsx eax, word [ebp-0x38] */
            ii(0x1007_d915, 5); call(0x100a_23e4, 0x2_4aca);            /* call 0x100a23e4 */
            ii(0x1007_d91a, 3); add(memd[ss, ebp - 32], eax);           /* add [ebp-0x20], eax */
            ii(0x1007_d91d, 3); lea(edx, memd[ss, ebp - 56]);           /* lea edx, [ebp-0x38] */
            ii(0x1007_d920, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_d923, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1007_d926, 5); call(0x1008_b2a8, 0xd97d);              /* call 0x1008b2a8 */
            ii(0x1007_d92b, 4); movsx(edx, memw[ss, ebp - 56]);         /* movsx edx, word [ebp-0x38] */
            ii(0x1007_d92f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_d932, 5); call(0x100a_63bc, 0x2_8a85);            /* call 0x100a63bc */
            ii(0x1007_d937, 5); jmp(0x1007_d847, -0xf5); goto l_0x1007_d847; /* jmp 0x1007d847 */
        l_0x1007_d93c:
            ii(0x1007_d93c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_d93e, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_d941, 5); call(0x1008_8dcc, 0xb486);              /* call 0x10088dcc */
        l_0x1007_d946:
            ii(0x1007_d946, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d948, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_d949, 1); pop(edi);                               /* pop edi */
            ii(0x1007_d94a, 1); pop(esi);                               /* pop esi */
            ii(0x1007_d94b, 1); ret();                                  /* ret */
        }
    }
}
