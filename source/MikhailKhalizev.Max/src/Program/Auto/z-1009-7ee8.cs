using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_7ee8-6936840a")]
        public void Method_1009_7ee8()
        {
            ii(0x1009_7ee8, 5); push(0x44);                             /* push 0x44 */
            ii(0x1009_7eed, 5); call(Definitions.sys_check_available_stack_size, 0xc_de60); /* call 0x10165d52 */
            ii(0x1009_7ef2, 1); push(esi);                              /* push esi */
            ii(0x1009_7ef3, 1); push(edi);                              /* push edi */
            ii(0x1009_7ef4, 1); push(ebp);                              /* push ebp */
            ii(0x1009_7ef5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_7ef7, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1009_7efd, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_7f00, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1009_7f03, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1009_7f06, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1009_7f09, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_7f0c, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_1421); /* call 0x10076af0 */
            ii(0x1009_7f11, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1009_7f15, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1009_7f18, 2); if(jnz(0x1009_7f46, 0x2c)) goto l_0x1009_7f46; /* jnz 0x10097f46 */
            ii(0x1009_7f1a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7f1d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7f1f, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_7f22, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1009_7f25, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1009_7f27, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7f2a, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1009_7f2d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7f2f, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7f31, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7f36, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1009_7f39, 2); if(jz(0x1009_7f44, 9)) goto l_0x1009_7f44; /* jz 0x10097f44 */
            ii(0x1009_7f3b, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_7f3f, 5); jmp(0x1009_81f7, 0x2b3); goto l_0x1009_81f7; /* jmp 0x100981f7 */
        l_0x1009_7f44:
            ii(0x1009_7f44, 2); jmp(0x1009_7f70, 0x2a); goto l_0x1009_7f70; /* jmp 0x10097f70 */
        l_0x1009_7f46:
            ii(0x1009_7f46, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7f49, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7f4b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_7f4e, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1009_7f51, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1009_7f53, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7f56, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1009_7f59, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7f5b, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7f5d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7f62, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1009_7f65, 2); if(jnz(0x1009_7f70, 9)) goto l_0x1009_7f70; /* jnz 0x10097f70 */
            ii(0x1009_7f67, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_7f6b, 5); jmp(0x1009_81f7, 0x287); goto l_0x1009_81f7; /* jmp 0x100981f7 */
        l_0x1009_7f70:
            ii(0x1009_7f70, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7f73, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_7f76, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x1009_7f7a, 2); jmp(0x1009_7f83, 7); goto l_0x1009_7f83; /* jmp 0x10097f83 */
        l_0x1009_7f7c:
            ii(0x1009_7f7c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_7f7f, 4); inc(memw[ss, ebp - 0x18]);              /* inc word [ebp-0x18] */
        l_0x1009_7f83:
            ii(0x1009_7f83, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1009_7f87, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7f8a, 3); cmp(edx, memd[ds, eax + 8]);            /* cmp edx, [eax+0x8] */
            ii(0x1009_7f8d, 2); if(jge(0x1009_7fdc, 0x4d)) goto l_0x1009_7fdc; /* jge 0x10097fdc */
            ii(0x1009_7f8f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7f92, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x1009_7f96, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x1009_7f9a, 2); jmp(0x1009_7fa3, 7); goto l_0x1009_7fa3; /* jmp 0x10097fa3 */
        l_0x1009_7f9c:
            ii(0x1009_7f9c, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1009_7f9f, 4); inc(memw[ss, ebp - 0x16]);              /* inc word [ebp-0x16] */
        l_0x1009_7fa3:
            ii(0x1009_7fa3, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1009_7fa7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7faa, 3); cmp(edx, memd[ds, eax + 0xc]);          /* cmp edx, [eax+0xc] */
            ii(0x1009_7fad, 2); if(jge(0x1009_7fda, 0x2b)) goto l_0x1009_7fda; /* jge 0x10097fda */
            ii(0x1009_7faf, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_7fb3, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1009_7fb6, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_7fb9, 5); call(0x1007_5e64, -0x2_215a);           /* call 0x10075e64 */
            ii(0x1009_7fbe, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7fc0, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_7fc3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_7fc6, 5); call(0x1009_7c97, -0x334);              /* call 0x10097c97 */
            ii(0x1009_7fcb, 2); test(al, al);                           /* test al, al */
            ii(0x1009_7fcd, 2); if(jz(0x1009_7fd8, 9)) goto l_0x1009_7fd8; /* jz 0x10097fd8 */
            ii(0x1009_7fcf, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_7fd3, 5); jmp(0x1009_81f7, 0x21f); goto l_0x1009_81f7; /* jmp 0x100981f7 */
        l_0x1009_7fd8:
            ii(0x1009_7fd8, 2); jmp(0x1009_7f9c, -0x3e); goto l_0x1009_7f9c; /* jmp 0x10097f9c */
        l_0x1009_7fda:
            ii(0x1009_7fda, 2); jmp(0x1009_7f7c, -0x60); goto l_0x1009_7f7c; /* jmp 0x10097f7c */
        l_0x1009_7fdc:
            ii(0x1009_7fdc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7fdf, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_7fe2, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x1009_7fe6, 2); jmp(0x1009_7fef, 7); goto l_0x1009_7fef; /* jmp 0x10097fef */
        l_0x1009_7fe8:
            ii(0x1009_7fe8, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_7feb, 4); inc(memw[ss, ebp - 0x18]);              /* inc word [ebp-0x18] */
        l_0x1009_7fef:
            ii(0x1009_7fef, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1009_7ff3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_7ff6, 3); cmp(edx, memd[ds, eax + 8]);            /* cmp edx, [eax+0x8] */
            ii(0x1009_7ff9, 6); if(jge(0x1009_80e9, 0xea)) goto l_0x1009_80e9; /* jge 0x100980e9 */
            ii(0x1009_7fff, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_8002, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x1009_8006, 1); dec(eax);                               /* dec eax */
            ii(0x1009_8007, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x1009_800b, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1009_800f, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_8012, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1009_8015, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1009_8019, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_801b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_801d, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_801f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_8024, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_8026, 2); if(jnz(0x1009_8048, 0x20)) goto l_0x1009_8048; /* jnz 0x10098048 */
            ii(0x1009_8028, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_802c, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1009_802f, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_8032, 5); call(0x1007_5e64, -0x2_21d3);           /* call 0x10075e64 */
            ii(0x1009_8037, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_8039, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_803c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_803f, 5); call(0x1009_7c97, -0x3ad);              /* call 0x10097c97 */
            ii(0x1009_8044, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8046, 2); if(jnz(0x1009_804a, 2)) goto l_0x1009_804a; /* jnz 0x1009804a */
        l_0x1009_8048:
            ii(0x1009_8048, 2); jmp(0x1009_8072, 0x28); goto l_0x1009_8072; /* jmp 0x10098072 */
        l_0x1009_804a:
            ii(0x1009_804a, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1009_804d, 1); inc(eax);                               /* inc eax */
            ii(0x1009_804e, 1); cwde();                                 /* cwde */
            ii(0x1009_804f, 1); push(eax);                              /* push eax */
            ii(0x1009_8050, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_8053, 1); inc(eax);                               /* inc eax */
            ii(0x1009_8054, 1); cwde();                                 /* cwde */
            ii(0x1009_8055, 1); push(eax);                              /* push eax */
            ii(0x1009_8056, 4); movsx(ecx, memw[ss, ebp - 0x16]);       /* movsx ecx, word [ebp-0x16] */
            ii(0x1009_805a, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1009_805e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_8061, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_8064, 5); call(0x1009_78bd, -0x7ac);              /* call 0x100978bd */
            ii(0x1009_8069, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_806d, 5); jmp(0x1009_81f7, 0x185); goto l_0x1009_81f7; /* jmp 0x100981f7 */
        l_0x1009_8072:
            ii(0x1009_8072, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_8075, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1009_8079, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x1009_807d, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1009_8081, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_8084, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1009_8087, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1009_808b, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_808d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_808f, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_8091, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_8096, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_8098, 2); if(jnz(0x1009_80ba, 0x20)) goto l_0x1009_80ba; /* jnz 0x100980ba */
            ii(0x1009_809a, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_809e, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1009_80a1, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_80a4, 5); call(0x1007_5e64, -0x2_2245);           /* call 0x10075e64 */
            ii(0x1009_80a9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_80ab, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_80ae, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_80b1, 5); call(0x1009_7c97, -0x41f);              /* call 0x10097c97 */
            ii(0x1009_80b6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_80b8, 2); if(jnz(0x1009_80bc, 2)) goto l_0x1009_80bc; /* jnz 0x100980bc */
        l_0x1009_80ba:
            ii(0x1009_80ba, 2); jmp(0x1009_80e4, 0x28); goto l_0x1009_80e4; /* jmp 0x100980e4 */
        l_0x1009_80bc:
            ii(0x1009_80bc, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1009_80bf, 1); inc(eax);                               /* inc eax */
            ii(0x1009_80c0, 1); cwde();                                 /* cwde */
            ii(0x1009_80c1, 1); push(eax);                              /* push eax */
            ii(0x1009_80c2, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_80c5, 1); inc(eax);                               /* inc eax */
            ii(0x1009_80c6, 1); cwde();                                 /* cwde */
            ii(0x1009_80c7, 1); push(eax);                              /* push eax */
            ii(0x1009_80c8, 4); movsx(ecx, memw[ss, ebp - 0x16]);       /* movsx ecx, word [ebp-0x16] */
            ii(0x1009_80cc, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1009_80d0, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_80d3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_80d6, 5); call(0x1009_78bd, -0x81e);              /* call 0x100978bd */
            ii(0x1009_80db, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_80df, 5); jmp(0x1009_81f7, 0x113); goto l_0x1009_81f7; /* jmp 0x100981f7 */
        l_0x1009_80e4:
            ii(0x1009_80e4, 5); jmp(0x1009_7fe8, -0x101); goto l_0x1009_7fe8; /* jmp 0x10097fe8 */
        l_0x1009_80e9:
            ii(0x1009_80e9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_80ec, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x1009_80f0, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x1009_80f4, 2); jmp(0x1009_80fd, 7); goto l_0x1009_80fd; /* jmp 0x100980fd */
        l_0x1009_80f6:
            ii(0x1009_80f6, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1009_80f9, 4); inc(memw[ss, ebp - 0x16]);              /* inc word [ebp-0x16] */
        l_0x1009_80fd:
            ii(0x1009_80fd, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1009_8101, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_8104, 3); cmp(edx, memd[ds, eax + 0xc]);          /* cmp edx, [eax+0xc] */
            ii(0x1009_8107, 6); if(jge(0x1009_81f3, 0xe6)) goto l_0x1009_81f3; /* jge 0x100981f3 */
            ii(0x1009_810d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_8110, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_8113, 1); dec(eax);                               /* dec eax */
            ii(0x1009_8114, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x1009_8118, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1009_811c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_811f, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1009_8122, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1009_8126, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_8128, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_812a, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_812c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_8131, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_8133, 2); if(jnz(0x1009_8155, 0x20)) goto l_0x1009_8155; /* jnz 0x10098155 */
            ii(0x1009_8135, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_8139, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1009_813c, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_813f, 5); call(0x1007_5e64, -0x2_22e0);           /* call 0x10075e64 */
            ii(0x1009_8144, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_8146, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_8149, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_814c, 5); call(0x1009_7c97, -0x4ba);              /* call 0x10097c97 */
            ii(0x1009_8151, 2); test(al, al);                           /* test al, al */
            ii(0x1009_8153, 2); if(jnz(0x1009_8157, 2)) goto l_0x1009_8157; /* jnz 0x10098157 */
        l_0x1009_8155:
            ii(0x1009_8155, 2); jmp(0x1009_817f, 0x28); goto l_0x1009_817f; /* jmp 0x1009817f */
        l_0x1009_8157:
            ii(0x1009_8157, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1009_815a, 1); inc(eax);                               /* inc eax */
            ii(0x1009_815b, 1); cwde();                                 /* cwde */
            ii(0x1009_815c, 1); push(eax);                              /* push eax */
            ii(0x1009_815d, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_8160, 1); inc(eax);                               /* inc eax */
            ii(0x1009_8161, 1); cwde();                                 /* cwde */
            ii(0x1009_8162, 1); push(eax);                              /* push eax */
            ii(0x1009_8163, 4); movsx(ecx, memw[ss, ebp - 0x16]);       /* movsx ecx, word [ebp-0x16] */
            ii(0x1009_8167, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1009_816b, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_816e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_8171, 5); call(0x1009_78bd, -0x8b9);              /* call 0x100978bd */
            ii(0x1009_8176, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_817a, 5); jmp(0x1009_81f7, 0x78); goto l_0x1009_81f7; /* jmp 0x100981f7 */
        l_0x1009_817f:
            ii(0x1009_817f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_8182, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1009_8186, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x1009_818a, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1009_818e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_8191, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1009_8194, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1009_8198, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_819a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_819c, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_819e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_81a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_81a5, 2); if(jnz(0x1009_81c7, 0x20)) goto l_0x1009_81c7; /* jnz 0x100981c7 */
            ii(0x1009_81a7, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_81ab, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1009_81ae, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1009_81b1, 5); call(0x1007_5e64, -0x2_2352);           /* call 0x10075e64 */
            ii(0x1009_81b6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_81b8, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_81bb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_81be, 5); call(0x1009_7c97, -0x52c);              /* call 0x10097c97 */
            ii(0x1009_81c3, 2); test(al, al);                           /* test al, al */
            ii(0x1009_81c5, 2); if(jnz(0x1009_81c9, 2)) goto l_0x1009_81c9; /* jnz 0x100981c9 */
        l_0x1009_81c7:
            ii(0x1009_81c7, 2); jmp(0x1009_81ee, 0x25); goto l_0x1009_81ee; /* jmp 0x100981ee */
        l_0x1009_81c9:
            ii(0x1009_81c9, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1009_81cc, 1); inc(eax);                               /* inc eax */
            ii(0x1009_81cd, 1); cwde();                                 /* cwde */
            ii(0x1009_81ce, 1); push(eax);                              /* push eax */
            ii(0x1009_81cf, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_81d2, 1); inc(eax);                               /* inc eax */
            ii(0x1009_81d3, 1); cwde();                                 /* cwde */
            ii(0x1009_81d4, 1); push(eax);                              /* push eax */
            ii(0x1009_81d5, 4); movsx(ecx, memw[ss, ebp - 0x16]);       /* movsx ecx, word [ebp-0x16] */
            ii(0x1009_81d9, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1009_81dd, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_81e0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_81e3, 5); call(0x1009_78bd, -0x92b);              /* call 0x100978bd */
            ii(0x1009_81e8, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_81ec, 2); jmp(0x1009_81f7, 9); goto l_0x1009_81f7; /* jmp 0x100981f7 */
        l_0x1009_81ee:
            ii(0x1009_81ee, 5); jmp(0x1009_80f6, -0xfd); goto l_0x1009_80f6; /* jmp 0x100980f6 */
        l_0x1009_81f3:
            ii(0x1009_81f3, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1009_81f7:
            ii(0x1009_81f7, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1009_81fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_81fc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_81fd, 1); pop(edi);                               /* pop edi */
            ii(0x1009_81fe, 1); pop(esi);                               /* pop esi */
            ii(0x1009_81ff, 1); ret();                                  /* ret */
        }
    }
}
