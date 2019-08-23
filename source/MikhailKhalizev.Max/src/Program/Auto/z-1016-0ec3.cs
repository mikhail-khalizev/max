using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_0ec3-98a8e9c3")]
        public void Method_1016_0ec3()
        {
            ii(0x1016_0ec3, 5); push(0x50);                             /* push 0x50 */
            ii(0x1016_0ec8, 5); call(Definitions.sys_check_available_stack_size, 0x4e85); /* call 0x10165d52 */
            ii(0x1016_0ecd, 1); push(ebx);                              /* push ebx */
            ii(0x1016_0ece, 1); push(ecx);                              /* push ecx */
            ii(0x1016_0ecf, 1); push(edx);                              /* push edx */
            ii(0x1016_0ed0, 1); push(esi);                              /* push esi */
            ii(0x1016_0ed1, 1); push(edi);                              /* push edi */
            ii(0x1016_0ed2, 1); push(ebp);                              /* push ebp */
            ii(0x1016_0ed3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_0ed5, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1016_0edb, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_0ede, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1016_0ee2, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1016_0ee5, 5); call(Definitions.my_ctor_0x101b_38f8, -0xe_a7fa); /* call 0x100766f0 */
            ii(0x1016_0eea, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1016_0eed, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1016_0ef1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0ef4, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1016_0ef7, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1016_0efa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0efd, 5); call(0x1014_9fa8, -0x1_6f5a);           /* call 0x10149fa8 */
            ii(0x1016_0f02, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0f05, 4); cmp(memb[ds, eax + 0x4d], 0);           /* cmp byte [eax+0x4d], 0x0 */
            ii(0x1016_0f09, 2); if(jz(0x1016_0f28, 0x1d)) goto l_0x1016_0f28; /* jz 0x10160f28 */
            ii(0x1016_0f0b, 5); call(0x1010_2bf8, -0x5_e318);           /* call 0x10102bf8 */
            ii(0x1016_0f10, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_0f12, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_0f14, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1016_0f19, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_0f1c, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_0f21, 5); call(0x1013_d5c0, -0x2_3966);           /* call 0x1013d5c0 */
            ii(0x1016_0f26, 2); jmp(0x1016_0f6c, 0x44); goto l_0x1016_0f6c; /* jmp 0x10160f6c */
        l_0x1016_0f28:
            ii(0x1016_0f28, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_0f2d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0f30, 5); call(0x1007_6d98, -0xe_a19d);           /* call 0x10076d98 */
            ii(0x1016_0f35, 2); test(al, al);                           /* test al, al */
            ii(0x1016_0f37, 2); if(jz(0x1016_0f51, 0x18)) goto l_0x1016_0f51; /* jz 0x10160f51 */
            ii(0x1016_0f39, 5); call(0x1010_2bf8, -0x5_e346);           /* call 0x10102bf8 */
            ii(0x1016_0f3e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_0f40, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_0f42, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_0f44, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_0f47, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_0f4c, 5); call(0x1013_d5c0, -0x2_3991);           /* call 0x1013d5c0 */
        l_0x1016_0f51:
            ii(0x1016_0f51, 5); call(0x1010_2bf8, -0x5_e35e);           /* call 0x10102bf8 */
            ii(0x1016_0f56, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_0f58, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_0f5a, 5); mov(ebx, 0xe);                          /* mov ebx, 0xe */
            ii(0x1016_0f5f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_0f62, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_0f67, 5); call(0x1013_d5c0, -0x2_39ac);           /* call 0x1013d5c0 */
        l_0x1016_0f6c:
            ii(0x1016_0f6c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0f6f, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1016_0f74, 2); if(jz(0x1016_0f80, 0xa)) goto l_0x1016_0f80; /* jz 0x10160f80 */
            ii(0x1016_0f76, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0f79, 5); cmp(memw[ds, eax + 0x8], 0x43);         /* cmp word [eax+0x8], 0x43 */
            ii(0x1016_0f7e, 2); if(jnz(0x1016_0f8f, 0xf)) goto l_0x1016_0f8f; /* jnz 0x10160f8f */
        l_0x1016_0f80:
            ii(0x1016_0f80, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0f83, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1016_0f86, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0f8b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_0f8d, 2); if(jz(0x1016_0f94, 0x5)) goto l_0x1016_0f94; /* jz 0x10160f94 */
        l_0x1016_0f8f:
            ii(0x1016_0f8f, 5); jmp(0x1016_1025, 0x91); goto l_0x1016_1025; /* jmp 0x10161025 */
        l_0x1016_0f94:
            ii(0x1016_0f94, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0f97, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1016_0f9c, 2); if(jnz(0x1016_0fa9, 0xb)) goto l_0x1016_0fa9; /* jnz 0x10160fa9 */
            ii(0x1016_0f9e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0fa1, 6); mov(memw[ds, eax + 0x33], 0xa8);        /* mov word [eax+0x33], 0xa8 */
            ii(0x1016_0fa7, 2); jmp(0x1016_0fb2, 0x9); goto l_0x1016_0fb2; /* jmp 0x10160fb2 */
        l_0x1016_0fa9:
            ii(0x1016_0fa9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0fac, 6); mov(memw[ds, eax + 0x33], 0xa8);        /* mov word [eax+0x33], 0xa8 */
        l_0x1016_0fb2:
            ii(0x1016_0fb2, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_0fb5, 3); mov(dl, memb[ds, edx + 0x29]);          /* mov dl, [edx+0x29] */
            ii(0x1016_0fb8, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1016_0fbe, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_0fc0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_0fc3, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_0fc5, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1016_0fc7, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1016_0fca, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_0fcd, 3); mov(edx, memd[ds, edx + 0x31]);         /* mov edx, [edx+0x31] */
            ii(0x1016_0fd0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_0fd3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_0fd5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0fd8, 4); mov(memw[ds, eax + 0x33], dx);          /* mov [eax+0x33], dx */
            ii(0x1016_0fdc, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_0fdf, 4); mov(dx, memw[ds, edx + 0x33]);          /* mov dx, [edx+0x33] */
            ii(0x1016_0fe3, 3); add(edx, 0x7);                          /* add edx, 0x7 */
            ii(0x1016_0fe6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0fe9, 4); mov(memw[ds, eax + 0x3b], dx);          /* mov [eax+0x3b], dx */
            ii(0x1016_0fed, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0ff0, 3); mov(edx, memd[ds, eax + 0x31]);         /* mov edx, [eax+0x31] */
            ii(0x1016_0ff3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_0ff6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_0ff9, 5); call(0x1014_9b07, -0x1_74f7);           /* call 0x10149b07 */
            ii(0x1016_0ffe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1001, 4); mov(memb[ds, eax + 0x3e], 0xe);         /* mov byte [eax+0x3e], 0xe */
            ii(0x1016_1005, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1008, 4); mov(memb[ds, eax + 0x5e], 0);           /* mov byte [eax+0x5e], 0x0 */
            ii(0x1016_100c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_100e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1011, 5); call(0x1008_a998, -0xd_667e);           /* call 0x1008a998 */
            ii(0x1016_1016, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1018, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1016_101b, 5); call(0x1007_5f2c, -0xe_b0f4);           /* call 0x10075f2c */
            ii(0x1016_1020, 5); jmp(0x1016_11d2, 0x1ad); goto l_0x1016_11d2; /* jmp 0x101611d2 */
        l_0x1016_1025:
            ii(0x1016_1025, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1028, 4); cmp(memb[ds, eax + 0x4d], 0);           /* cmp byte [eax+0x4d], 0x0 */
            ii(0x1016_102c, 2); if(jz(0x1016_1037, 0x9)) goto l_0x1016_1037; /* jz 0x10161037 */
            ii(0x1016_102e, 7); mov(memd[ss, ebp - 0xc], 0x2f);         /* mov dword [ebp-0xc], 0x2f */
            ii(0x1016_1035, 2); jmp(0x1016_1086, 0x4f); goto l_0x1016_1086; /* jmp 0x10161086 */
        l_0x1016_1037:
            ii(0x1016_1037, 7); test(memd[ss, ebp - 0x14], 0x10);       /* test dword [ebp-0x14], 0x10 */
            ii(0x1016_103e, 2); if(jz(0x1016_1049, 0x9)) goto l_0x1016_1049; /* jz 0x10161049 */
            ii(0x1016_1040, 7); mov(memd[ss, ebp - 0xc], 0x2e);         /* mov dword [ebp-0xc], 0x2e */
            ii(0x1016_1047, 2); jmp(0x1016_1086, 0x3d); goto l_0x1016_1086; /* jmp 0x10161086 */
        l_0x1016_1049:
            ii(0x1016_1049, 7); test(memd[ss, ebp - 0x14], 0x100);      /* test dword [ebp-0x14], 0x100 */
            ii(0x1016_1050, 2); if(jz(0x1016_105b, 0x9)) goto l_0x1016_105b; /* jz 0x1016105b */
            ii(0x1016_1052, 7); mov(memd[ss, ebp - 0xc], 0x2b);         /* mov dword [ebp-0xc], 0x2b */
            ii(0x1016_1059, 2); jmp(0x1016_1086, 0x2b); goto l_0x1016_1086; /* jmp 0x10161086 */
        l_0x1016_105b:
            ii(0x1016_105b, 7); test(memd[ss, ebp - 0x14], 0x40);       /* test dword [ebp-0x14], 0x40 */
            ii(0x1016_1062, 2); if(jz(0x1016_106d, 0x9)) goto l_0x1016_106d; /* jz 0x1016106d */
            ii(0x1016_1064, 7); mov(memd[ss, ebp - 0xc], 0x2c);         /* mov dword [ebp-0xc], 0x2c */
            ii(0x1016_106b, 2); jmp(0x1016_1086, 0x19); goto l_0x1016_1086; /* jmp 0x10161086 */
        l_0x1016_106d:
            ii(0x1016_106d, 7); test(memd[ss, ebp - 0x14], 0x80);       /* test dword [ebp-0x14], 0x80 */
            ii(0x1016_1074, 2); if(jz(0x1016_107f, 0x9)) goto l_0x1016_107f; /* jz 0x1016107f */
            ii(0x1016_1076, 7); mov(memd[ss, ebp - 0xc], 0x2d);         /* mov dword [ebp-0xc], 0x2d */
            ii(0x1016_107d, 2); jmp(0x1016_1086, 0x7); goto l_0x1016_1086; /* jmp 0x10161086 */
        l_0x1016_107f:
            ii(0x1016_107f, 7); mov(memd[ss, ebp - 0xc], 0x2b);         /* mov dword [ebp-0xc], 0x2b */
        l_0x1016_1086:
            ii(0x1016_1086, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1016_108a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_108d, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1016_1092, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_1094, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x1016_1097, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1016_109a, 5); and(memw[ds, eax], 0xfc1f);             /* and word [eax], 0xfc1f */
            ii(0x1016_109f, 7); test(memd[ss, ebp - 0x14], 0x1);        /* test dword [ebp-0x14], 0x1 */
            ii(0x1016_10a6, 2); if(jz(0x1016_10b1, 0x9)) goto l_0x1016_10b1; /* jz 0x101610b1 */
            ii(0x1016_10a8, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1016_10ab, 4); or(memb[ds, eax + 0x1], 0x1);           /* or byte [eax+0x1], 0x1 */
            ii(0x1016_10af, 2); jmp(0x1016_10da, 0x29); goto l_0x1016_10da; /* jmp 0x101610da */
        l_0x1016_10b1:
            ii(0x1016_10b1, 7); test(memd[ss, ebp - 0x14], 0x180);      /* test dword [ebp-0x14], 0x180 */
            ii(0x1016_10b8, 2); if(jz(0x1016_10c3, 0x9)) goto l_0x1016_10c3; /* jz 0x101610c3 */
            ii(0x1016_10ba, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1016_10bd, 4); or(memb[ds, eax + 0x1], 0x2);           /* or byte [eax+0x1], 0x2 */
            ii(0x1016_10c1, 2); jmp(0x1016_10da, 0x17); goto l_0x1016_10da; /* jmp 0x101610da */
        l_0x1016_10c3:
            ii(0x1016_10c3, 7); test(memd[ss, ebp - 0x14], 0x200);      /* test dword [ebp-0x14], 0x200 */
            ii(0x1016_10ca, 2); if(jz(0x1016_10d4, 0x8)) goto l_0x1016_10d4; /* jz 0x101610d4 */
            ii(0x1016_10cc, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1016_10cf, 3); or(memb[ds, eax], 0x40);                /* or byte [eax], 0x40 */
            ii(0x1016_10d2, 2); jmp(0x1016_10da, 0x6); goto l_0x1016_10da; /* jmp 0x101610da */
        l_0x1016_10d4:
            ii(0x1016_10d4, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1016_10d7, 3); or(memb[ds, eax], 0x20);                /* or byte [eax], 0x20 */
        l_0x1016_10da:
            ii(0x1016_10da, 5); call(0x1010_2b84, -0x5_e55b);           /* call 0x10102b84 */
            ii(0x1016_10df, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_10e4, 1); push(eax);                              /* push eax */
            ii(0x1016_10e5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_10ea, 1); push(eax);                              /* push eax */
            ii(0x1016_10eb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_10ed, 1); push(eax);                              /* push eax */
            ii(0x1016_10ee, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_10f1, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1016_10f4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_10f7, 1); push(eax);                              /* push eax */
            ii(0x1016_10f8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_10fb, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1016_10fe, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_1101, 1); push(eax);                              /* push eax */
            ii(0x1016_1102, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_1104, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1107, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1016_110a, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_110c, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1016_110f, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1016_1113, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1016_1116, 5); call(0x1015_a2da, -0x6e41);             /* call 0x1015a2da */
            ii(0x1016_111b, 3); lea(ecx, memd[ss, ebp - 0x20]);         /* lea ecx, [ebp-0x20] */
            ii(0x1016_111e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1120, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_1122, 5); call(0x1008_ac18, -0xd_650f);           /* call 0x1008ac18 */
            ii(0x1016_1127, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1129, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1016_112c, 5); call(0x1007_5f2c, -0xe_b205);           /* call 0x10075f2c */
            ii(0x1016_1131, 5); cmp(memw[ss, ebp - 0xc], 0x2e);         /* cmp word [ebp-0xc], 0x2e */
            ii(0x1016_1136, 2); if(jz(0x1016_1173, 0x3b)) goto l_0x1016_1173; /* jz 0x10161173 */
            ii(0x1016_1138, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1016_113b, 5); call(0x1007_6574, -0xe_abcc);           /* call 0x10076574 */
            ii(0x1016_1140, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_1143, 4); mov(dx, memw[ds, edx + 0x18]);          /* mov dx, [edx+0x18] */
            ii(0x1016_1147, 4); sub(dx, memw[ds, eax + 0x18]);          /* sub dx, [eax+0x18] */
            ii(0x1016_114b, 3); movsx(ebx, dx);                         /* movsx ebx, dx */
            ii(0x1016_114e, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1016_1151, 5); call(0x1007_6574, -0xe_abe2);           /* call 0x10076574 */
            ii(0x1016_1156, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1158, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_115b, 4); mov(ax, memw[ds, eax + 0x16]);          /* mov ax, [eax+0x16] */
            ii(0x1016_115f, 4); sub(ax, memw[ds, edx + 0x16]);          /* sub ax, [edx+0x16] */
            ii(0x1016_1163, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_1166, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1016_1169, 5); call(0x1007_6574, -0xe_abfa);           /* call 0x10076574 */
            ii(0x1016_116e, 5); call(0x1014_9c2f, -0x1_7544);           /* call 0x10149c2f */
        l_0x1016_1173:
            ii(0x1016_1173, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1176, 5); call(0x1014_f08b, -0x1_20f0);           /* call 0x1014f08b */
            ii(0x1016_117b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_117e, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1016_1181, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_1186, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1188, 2); if(jnz(0x1016_11c8, 0x3e)) goto l_0x1016_11c8; /* jnz 0x101611c8 */
            ii(0x1016_118a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_118d, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1016_1190, 5); call(0x1007_6574, -0xe_ac21);           /* call 0x10076574 */
            ii(0x1016_1195, 5); call(0x1008_a998, -0xd_6802);           /* call 0x1008a998 */
            ii(0x1016_119a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_119d, 4); mov(memb[ds, eax + 0x3e], 0xe);         /* mov byte [eax+0x3e], 0xe */
            ii(0x1016_11a1, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_11a6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_11a9, 5); call(0x1007_6d98, -0xe_a416);           /* call 0x10076d98 */
            ii(0x1016_11ae, 2); test(al, al);                           /* test al, al */
            ii(0x1016_11b0, 2); if(jz(0x1016_11c8, 0x16)) goto l_0x1016_11c8; /* jz 0x101611c8 */
            ii(0x1016_11b2, 5); mov(eax, 0x57);                         /* mov eax, 0x57 */
            ii(0x1016_11b7, 5); call(0x1007_5fdc, -0xe_b1e0);           /* call 0x10075fdc */
            ii(0x1016_11bc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_11be, 2); if(jz(0x1016_11c8, 0x8)) goto l_0x1016_11c8; /* jz 0x101611c8 */
            ii(0x1016_11c0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_11c3, 5); call(0x1010_19b8, -0x5_f810);           /* call 0x101019b8 */
        l_0x1016_11c8:
            ii(0x1016_11c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_11ca, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1016_11cd, 5); call(0x1007_5f2c, -0xe_b2a6);           /* call 0x10075f2c */
        l_0x1016_11d2:
            ii(0x1016_11d2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_11d4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_11d5, 1); pop(edi);                               /* pop edi */
            ii(0x1016_11d6, 1); pop(esi);                               /* pop esi */
            ii(0x1016_11d7, 1); pop(edx);                               /* pop edx */
            ii(0x1016_11d8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_11d9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_11da, 1); ret();                                  /* ret */
        }
    }
}
