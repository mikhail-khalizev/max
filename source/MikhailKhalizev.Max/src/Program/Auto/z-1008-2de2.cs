using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_2de2-ae496e62")]
        public void Method_1008_2de2()
        {
            ii(0x1008_2de2, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1008_2de7, 5); call(Definitions.sys_check_available_stack_size, 0xe_2f66); /* call 0x10165d52 */
            ii(0x1008_2dec, 1); push(ecx);                              /* push ecx */
            ii(0x1008_2ded, 1); push(esi);                              /* push esi */
            ii(0x1008_2dee, 1); push(edi);                              /* push edi */
            ii(0x1008_2def, 1); push(ebp);                              /* push ebp */
            ii(0x1008_2df0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_2df2, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1008_2df8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_2dfb, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1008_2dfe, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1008_2e01, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_2e04, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_2e07, 5); call(0x1008_9d08, 0x6efc);              /* call 0x10089d08 */
            ii(0x1008_2e0c, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1008_2e0f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2e11, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_2e13, 5); call(0x1008_9be4, 0x6dcc);              /* call 0x10089be4 */
            ii(0x1008_2e18, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_2e1b, 5); call(Definitions.my_ctor_0x101b_4184, -0xc330); /* call 0x10076af0 */
            ii(0x1008_2e20, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_2e23, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1008_2e28, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2e2b, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1008_2e30, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2e32, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_2e35, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_2e38, 5); call(0x1013_ad11, 0xb_7ed4);            /* call 0x1013ad11 */
            ii(0x1008_2e3d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2e3f, 2); if(jz(0x1008_2e50, 0xf)) goto l_0x1008_2e50; /* jz 0x10082e50 */
            ii(0x1008_2e41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2e43, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_2e46, 5); call(0x1008_9044, 0x61f9);              /* call 0x10089044 */
            ii(0x1008_2e4b, 5); jmp(0x1008_3035, 0x1e5); goto l_0x1008_3035; /* jmp 0x10083035 */
        l_0x1008_2e50:
            ii(0x1008_2e50, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_2e53, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_2e56, 5); call(0x1008_9d7c, 0x6f21);              /* call 0x10089d7c */
            ii(0x1008_2e5b, 5); call(0x1008_9f70, 0x7110);              /* call 0x10089f70 */
            ii(0x1008_2e60, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_2e63, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_2e66, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1008_2e6a, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x1008_2e6e, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_2e71, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1008_2e75, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x1008_2e79, 2); jmp(0x1008_2e83, 0x8); goto l_0x1008_2e83; /* jmp 0x10082e83 */
        l_0x1008_2e7b:
            ii(0x1008_2e7b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_2e7e, 5); call(0x1007_6bf8, -0xc28b);             /* call 0x10076bf8 */
        l_0x1008_2e83:
            ii(0x1008_2e83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2e85, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_2e88, 5); call(0x1013_ad71, 0xb_7ee4);            /* call 0x1013ad71 */
            ii(0x1008_2e8d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2e8f, 6); if(jz(0x1008_2f57, 0xc2)) goto l_0x1008_2f57; /* jz 0x10082f57 */
            ii(0x1008_2e95, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_2e98, 5); call(0x1008_9acc, 0x6c2f);              /* call 0x10089acc */
            ii(0x1008_2e9d, 5); call(0x1008_9f70, 0x70ce);              /* call 0x10089f70 */
            ii(0x1008_2ea2, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_2ea5, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1008_2ea9, 6); if(jz(0x1008_2f52, 0xa3)) goto l_0x1008_2f52; /* jz 0x10082f52 */
            ii(0x1008_2eaf, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_2eb2, 5); call(0x1007_623c, -0xcc7b);             /* call 0x1007623c */
            ii(0x1008_2eb7, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_2eba, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_2ebd, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1008_2ec0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_2ec3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2ec5, 6); if(jle(0x1008_2f52, 0x87)) goto l_0x1008_2f52; /* jle 0x10082f52 */
            ii(0x1008_2ecb, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_2ece, 5); call(0x1008_9b34, 0x6c61);              /* call 0x10089b34 */
            ii(0x1008_2ed3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2ed5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_2ed8, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_2edb, 5); call(0x1008_9e08, 0x6f28);              /* call 0x10089e08 */
            ii(0x1008_2ee0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_2ee2, 2); if(jz(0x1008_2eff, 0x1b)) goto l_0x1008_2eff; /* jz 0x10082eff */
            ii(0x1008_2ee4, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1008_2ee7, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1008_2eea, 5); call(0x1007_5e64, -0xd08b);             /* call 0x10075e64 */
            ii(0x1008_2eef, 3); mov(ebx, memd[ss, ebp - 0x20]);         /* mov ebx, [ebp-0x20] */
            ii(0x1008_2ef2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2ef4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_2ef6, 5); call(0x1008_2d5c, -0x19f);              /* call 0x10082d5c */
            ii(0x1008_2efb, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2efd, 2); if(jz(0x1008_2f52, 0x53)) goto l_0x1008_2f52; /* jz 0x10082f52 */
        l_0x1008_2eff:
            ii(0x1008_2eff, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x1008_2f04, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_2f07, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1008_2f0a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_2f0d, 5); call(0x1007_49d4, -0xe53e);             /* call 0x100749d4 */
            ii(0x1008_2f12, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2f14, 2); if(jz(0x1008_2f35, 0x1f)) goto l_0x1008_2f35; /* jz 0x10082f35 */
            ii(0x1008_2f16, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_2f19, 3); mov(edx, memd[ds, eax + 0x10]);         /* mov edx, [eax+0x10] */
            ii(0x1008_2f1c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_2f1f, 1); inc(edx);                               /* inc edx */
            ii(0x1008_2f20, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_2f23, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1008_2f26, 5); call(0x1007_6e7c, -0xc0af);             /* call 0x10076e7c */
            ii(0x1008_2f2b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2f2d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_2f30, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1008_2f33, 2); jmp(0x1008_2f52, 0x1d); goto l_0x1008_2f52; /* jmp 0x10082f52 */
        l_0x1008_2f35:
            ii(0x1008_2f35, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_2f38, 3); mov(edx, memd[ds, eax + 0x10]);         /* mov edx, [eax+0x10] */
            ii(0x1008_2f3b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_2f3e, 1); inc(edx);                               /* inc edx */
            ii(0x1008_2f3f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2f42, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1008_2f45, 5); call(0x1007_6e7c, -0xc0ce);             /* call 0x10076e7c */
            ii(0x1008_2f4a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2f4c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_2f4f, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
        l_0x1008_2f52:
            ii(0x1008_2f52, 5); jmp(0x1008_2e7b, -0xdc); goto l_0x1008_2e7b; /* jmp 0x10082e7b */
        l_0x1008_2f57:
            ii(0x1008_2f57, 5); mov(ebx, 0x4f);                         /* mov ebx, 0x4f */
            ii(0x1008_2f5c, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1008_2f5f, 3); mov(edx, memd[ds, edx + 0x7]);          /* mov edx, [edx+0x7] */
            ii(0x1008_2f62, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_2f65, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1008_2f6b, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1008_2f70, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_2f72, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_2f74, 5); call(0x100d_fd2c, 0x5_cdb3);            /* call 0x100dfd2c */
            ii(0x1008_2f79, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2f7b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_2f7e, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1008_2f81, 4); sub(ax, memw[ds, edx + 0x17]);          /* sub ax, [edx+0x17] */
            ii(0x1008_2f85, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_2f88, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1008_2f8b, 4); test(memb[ds, edx + 0x3b], 0x1);        /* test byte [edx+0x3b], 0x1 */
            ii(0x1008_2f8f, 2); if(jz(0x1008_2fc0, 0x2f)) goto l_0x1008_2fc0; /* jz 0x10082fc0 */
            ii(0x1008_2f91, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x1008_2f96, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_2f99, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_2f9c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_2f9f, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x1008_2fa5, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1008_2faa, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_2fac, 5); call(0x100d_fd2c, 0x5_cd7b);            /* call 0x100dfd2c */
            ii(0x1008_2fb1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_2fb4, 3); mov(dx, memw[ds, edx]);                 /* mov dx, [edx] */
            ii(0x1008_2fb7, 4); sub(dx, memw[ds, eax + 0x17]);          /* sub dx, [eax+0x17] */
            ii(0x1008_2fbb, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1008_2fbe, 2); jmp(0x1008_2fed, 0x2d); goto l_0x1008_2fed; /* jmp 0x10082fed */
        l_0x1008_2fc0:
            ii(0x1008_2fc0, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x1008_2fc5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_2fc8, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_2fcb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_2fce, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x1008_2fd4, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1008_2fd9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_2fdb, 5); call(0x100d_fd2c, 0x5_cd4c);            /* call 0x100dfd2c */
            ii(0x1008_2fe0, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_2fe3, 3); mov(dx, memw[ds, edx]);                 /* mov dx, [edx] */
            ii(0x1008_2fe6, 4); sub(dx, memw[ds, eax + 0x17]);          /* sub dx, [eax+0x17] */
            ii(0x1008_2fea, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
        l_0x1008_2fed:
            ii(0x1008_2fed, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_2ff1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2ff3, 2); if(jle(0x1008_2ffd, 0x8)) goto l_0x1008_2ffd; /* jle 0x10082ffd */
            ii(0x1008_2ff5, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1008_2ff9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2ffb, 2); if(jg(0x1008_3009, 0xc)) goto l_0x1008_3009; /* jg 0x10083009 */
        l_0x1008_2ffd:
            ii(0x1008_2ffd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2fff, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_3002, 5); call(0x1008_9044, 0x603d);              /* call 0x10089044 */
            ii(0x1008_3007, 2); jmp(0x1008_3035, 0x2c); goto l_0x1008_3035; /* jmp 0x10083035 */
        l_0x1008_3009:
            ii(0x1008_3009, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1008_300d, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_3011, 5); call(Definitions.my_min, 0x676e);       /* call 0x10089784 */
            ii(0x1008_3016, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_3019, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_301c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_301f, 3); sub(memw[ds, edx], ax);                 /* sub [edx], ax */
            ii(0x1008_3022, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_3025, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_3028, 3); sub(memw[ds, edx], ax);                 /* sub [edx], ax */
            ii(0x1008_302b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_302d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1008_3030, 5); call(0x1008_9044, 0x600f);              /* call 0x10089044 */
        l_0x1008_3035:
            ii(0x1008_3035, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_3037, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_3038, 1); pop(edi);                               /* pop edi */
            ii(0x1008_3039, 1); pop(esi);                               /* pop esi */
            ii(0x1008_303a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_303b, 1); ret();                                  /* ret */
        }
    }
}
