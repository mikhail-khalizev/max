using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_f9ae-cac649ad")]
        public void Method_1015_f9ae()
        {
            ii(0x1015_f9ae, 5); push(0x54);                             /* push 0x54 */
            ii(0x1015_f9b3, 5); call(Definitions.sys_check_available_stack_size, 0x639a); /* call 0x10165d52 */
            ii(0x1015_f9b8, 1); push(ebx);                              /* push ebx */
            ii(0x1015_f9b9, 1); push(ecx);                              /* push ecx */
            ii(0x1015_f9ba, 1); push(edx);                              /* push edx */
            ii(0x1015_f9bb, 1); push(esi);                              /* push esi */
            ii(0x1015_f9bc, 1); push(edi);                              /* push edi */
            ii(0x1015_f9bd, 1); push(ebp);                              /* push ebp */
            ii(0x1015_f9be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_f9c0, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1015_f9c6, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_f9c9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f9cb, 1); push(eax);                              /* push eax */
            ii(0x1015_f9cc, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f9ce, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_f9d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f9d2, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_f9d5, 5); call(0x1008_b148, -0xd_4892);           /* call 0x1008b148 */
            ii(0x1015_f9da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_f9dd, 5); call(0x1007_611c, -0xe_98c6);           /* call 0x1007611c */
            ii(0x1015_f9e2, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1015_f9e5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_f9e7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_f9e9, 5); call(0x1007_66ac, -0xe_9342);           /* call 0x100766ac */
            ii(0x1015_f9ee, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_f9f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f9f4, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_f9f7, 5); call(0x1013_ad11, -0x2_4ceb);           /* call 0x1013ad11 */
            ii(0x1015_f9fc, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f9fe, 2); if(jz(0x1015_fa09, 0x9)) goto l_0x1015_fa09; /* jz 0x1015fa09 */
            ii(0x1015_fa00, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_fa04, 5); jmp(0x1015_faf1, 0xe8); goto l_0x1015_faf1; /* jmp 0x1015faf1 */
        l_0x1015_fa09:
            ii(0x1015_fa09, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fa0c, 5); call(0x1007_6574, -0xe_949d);           /* call 0x10076574 */
            ii(0x1015_fa11, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1015_fa14, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_fa19, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_fa1b, 2); if(jnz(0x1015_fa80, 0x63)) goto l_0x1015_fa80; /* jnz 0x1015fa80 */
            ii(0x1015_fa1d, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1015_fa20, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fa23, 5); call(0x1015_2532, -0xd4f6);             /* call 0x10152532 */
            ii(0x1015_fa28, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fa2b, 5); call(0x1007_6574, -0xe_94bc);           /* call 0x10076574 */
            ii(0x1015_fa30, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_fa33, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_fa36, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fa39, 5); call(0x1007_6574, -0xe_94ca);           /* call 0x10076574 */
            ii(0x1015_fa3e, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1015_fa41, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_fa44, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_fa47, 5); call(0x1007_6aac, -0xe_8fa0);           /* call 0x10076aac */
            ii(0x1015_fa4c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_fa4e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_fa51, 5); call(0x1010_82ce, -0x5_7788);           /* call 0x101082ce */
            ii(0x1015_fa56, 2); test(al, al);                           /* test al, al */
            ii(0x1015_fa58, 2); if(jnz(0x1015_fa60, 0x6)) goto l_0x1015_fa60; /* jnz 0x1015fa60 */
            ii(0x1015_fa5a, 4); mov(memb[ss, ebp - 0x24], 0x1);         /* mov byte [ebp-0x24], 0x1 */
            ii(0x1015_fa5e, 2); jmp(0x1015_fa64, 0x4); goto l_0x1015_fa64; /* jmp 0x1015fa64 */
        l_0x1015_fa60:
            ii(0x1015_fa60, 4); mov(memb[ss, ebp - 0x24], 0);           /* mov byte [ebp-0x24], 0x0 */
        l_0x1015_fa64:
            ii(0x1015_fa64, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x1015_fa67, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
            ii(0x1015_fa6a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_fa6c, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1015_fa6f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_fa71, 2); if(jnz(0x1015_fa7b, 0x8)) goto l_0x1015_fa7b; /* jnz 0x1015fa7b */
            ii(0x1015_fa73, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fa76, 5); call(0x1015_f2cc, -0x7af);              /* call 0x1015f2cc */
        l_0x1015_fa7b:
            ii(0x1015_fa7b, 5); jmp(0x1015_faf1, 0x71); goto l_0x1015_faf1; /* jmp 0x1015faf1 */
        l_0x1015_fa80:
            ii(0x1015_fa80, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fa83, 5); call(0x1007_6574, -0xe_9514);           /* call 0x10076574 */
            ii(0x1015_fa88, 4); cmp(memb[ds, eax + 0x3d], 0x2);         /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1015_fa8c, 2); if(jnz(0x1015_fa9c, 0xe)) goto l_0x1015_fa9c; /* jnz 0x1015fa9c */
            ii(0x1015_fa8e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fa91, 5); call(0x1007_6574, -0xe_9522);           /* call 0x10076574 */
            ii(0x1015_fa96, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1015_fa9a, 2); if(jnz(0x1015_fa9e, 0x2)) goto l_0x1015_fa9e; /* jnz 0x1015fa9e */
        l_0x1015_fa9c:
            ii(0x1015_fa9c, 2); jmp(0x1015_faa4, 0x6); goto l_0x1015_faa4; /* jmp 0x1015faa4 */
        l_0x1015_fa9e:
            ii(0x1015_fa9e, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_faa2, 2); jmp(0x1015_faf1, 0x4d); goto l_0x1015_faf1; /* jmp 0x1015faf1 */
        l_0x1015_faa4:
            ii(0x1015_faa4, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1015_faa7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_faaa, 5); call(0x1015_2532, -0xd57d);             /* call 0x10152532 */
            ii(0x1015_faaf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fab2, 5); call(0x1007_6574, -0xe_9543);           /* call 0x10076574 */
            ii(0x1015_fab7, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_faba, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_fabd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fac0, 5); call(0x1007_6574, -0xe_9551);           /* call 0x10076574 */
            ii(0x1015_fac5, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1015_fac8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_facb, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1015_face, 5); call(0x1007_6aac, -0xe_9027);           /* call 0x10076aac */
            ii(0x1015_fad3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_fad5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_fad8, 5); call(0x1010_82ce, -0x5_780f);           /* call 0x101082ce */
            ii(0x1015_fadd, 2); test(al, al);                           /* test al, al */
            ii(0x1015_fadf, 2); if(jnz(0x1015_fae7, 0x6)) goto l_0x1015_fae7; /* jnz 0x1015fae7 */
            ii(0x1015_fae1, 4); mov(memb[ss, ebp - 0x28], 0x1);         /* mov byte [ebp-0x28], 0x1 */
            ii(0x1015_fae5, 2); jmp(0x1015_faeb, 0x4); goto l_0x1015_faeb; /* jmp 0x1015faeb */
        l_0x1015_fae7:
            ii(0x1015_fae7, 4); mov(memb[ss, ebp - 0x28], 0);           /* mov byte [ebp-0x28], 0x0 */
        l_0x1015_faeb:
            ii(0x1015_faeb, 3); mov(al, memb[ss, ebp - 0x28]);          /* mov al, [ebp-0x28] */
            ii(0x1015_faee, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
        l_0x1015_faf1:
            ii(0x1015_faf1, 4); cmp(memb[ss, ebp - 0x8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1015_faf5, 6); if(jz(0x1015_fc36, 0x13b)) goto l_0x1015_fc36; /* jz 0x1015fc36 */
            ii(0x1015_fafb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fafe, 5); cmp(memw[ds, eax + 0x8], 0xc);          /* cmp word [eax+0x8], 0xc */
            ii(0x1015_fb03, 6); if(jz(0x1015_fbc6, 0xbd)) goto l_0x1015_fbc6; /* jz 0x1015fbc6 */
            ii(0x1015_fb09, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fb0c, 5); cmp(memw[ds, eax + 0x8], 0x15);         /* cmp word [eax+0x8], 0x15 */
            ii(0x1015_fb11, 2); if(jz(0x1015_fb19, 0x6)) goto l_0x1015_fb19; /* jz 0x1015fb19 */
            ii(0x1015_fb13, 4); mov(memb[ss, ebp - 0x30], 0x1);         /* mov byte [ebp-0x30], 0x1 */
            ii(0x1015_fb17, 2); jmp(0x1015_fb1d, 0x4); goto l_0x1015_fb1d; /* jmp 0x1015fb1d */
        l_0x1015_fb19:
            ii(0x1015_fb19, 4); mov(memb[ss, ebp - 0x30], 0);           /* mov byte [ebp-0x30], 0x0 */
        l_0x1015_fb1d:
            ii(0x1015_fb1d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_fb1f, 3); mov(al, memb[ss, ebp - 0x30]);          /* mov al, [ebp-0x30] */
            ii(0x1015_fb22, 1); push(eax);                              /* push eax */
            ii(0x1015_fb23, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_fb28, 1); push(eax);                              /* push eax */
            ii(0x1015_fb29, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_fb2b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_fb2d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fb30, 3); mov(edx, memd[ds, eax + 0x1a]);         /* mov edx, [eax+0x1a] */
            ii(0x1015_fb33, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_fb36, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fb39, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_fb3c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_fb3f, 5); call(0x1007_4395, -0xe_b7af);           /* call 0x10074395 */
            ii(0x1015_fb44, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fb47, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1015_fb4b, 2); if(jz(0x1015_fbc6, 0x79)) goto l_0x1015_fbc6; /* jz 0x1015fbc6 */
            ii(0x1015_fb4d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_fb52, 1); push(eax);                              /* push eax */
            ii(0x1015_fb53, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_fb58, 1); push(eax);                              /* push eax */
            ii(0x1015_fb59, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_fb5b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_fb5d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fb60, 3); mov(edx, memd[ds, eax + 0x1a]);         /* mov edx, [eax+0x1a] */
            ii(0x1015_fb63, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_fb66, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fb69, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1015_fb6d, 1); inc(eax);                               /* inc eax */
            ii(0x1015_fb6e, 1); cwde();                                 /* cwde */
            ii(0x1015_fb6f, 5); call(0x1007_4395, -0xe_b7df);           /* call 0x10074395 */
            ii(0x1015_fb74, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_fb79, 1); push(eax);                              /* push eax */
            ii(0x1015_fb7a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_fb7f, 1); push(eax);                              /* push eax */
            ii(0x1015_fb80, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_fb82, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_fb84, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fb87, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1015_fb8b, 1); inc(eax);                               /* inc eax */
            ii(0x1015_fb8c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_fb8f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fb92, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_fb95, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_fb98, 5); call(0x1007_4395, -0xe_b808);           /* call 0x10074395 */
            ii(0x1015_fb9d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_fba2, 1); push(eax);                              /* push eax */
            ii(0x1015_fba3, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_fba8, 1); push(eax);                              /* push eax */
            ii(0x1015_fba9, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_fbab, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_fbad, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fbb0, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1015_fbb4, 1); inc(eax);                               /* inc eax */
            ii(0x1015_fbb5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_fbb8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fbbb, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1015_fbbf, 1); inc(eax);                               /* inc eax */
            ii(0x1015_fbc0, 1); cwde();                                 /* cwde */
            ii(0x1015_fbc1, 5); call(0x1007_4395, -0xe_b831);           /* call 0x10074395 */
        l_0x1015_fbc6:
            ii(0x1015_fbc6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fbc9, 5); call(0x1014_f08b, -0x1_0b43);           /* call 0x1014f08b */
            ii(0x1015_fbce, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fbd1, 4); mov(memb[ds, eax + 0x2d], 0x4);         /* mov byte [eax+0x2d], 0x4 */
            ii(0x1015_fbd5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fbd7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fbda, 5); call(0x1008_a998, -0xd_5247);           /* call 0x1008a998 */
            ii(0x1015_fbdf, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1015_fbe4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fbe7, 5); call(0x1016_2f0a, 0x331e);              /* call 0x10162f0a */
            ii(0x1015_fbec, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_fbf1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_fbf4, 5); call(0x1007_1838, -0xe_e3c1);           /* call 0x10071838 */
            ii(0x1015_fbf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fbfb, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fbfe, 5); call(0x1013_ad71, -0x2_4e92);           /* call 0x1013ad71 */
            ii(0x1015_fc03, 2); test(al, al);                           /* test al, al */
            ii(0x1015_fc05, 2); if(jz(0x1015_fc2d, 0x26)) goto l_0x1015_fc2d; /* jz 0x1015fc2d */
            ii(0x1015_fc07, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fc0a, 5); call(0x1007_6574, -0xe_969b);           /* call 0x10076574 */
            ii(0x1015_fc0f, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_fc12, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_fc17, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_fc1d, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_fc23, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_fc28, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_fc2b, 2); if(jz(0x1015_fc2f, 0x2)) goto l_0x1015_fc2f; /* jz 0x1015fc2f */
        l_0x1015_fc2d:
            ii(0x1015_fc2d, 2); jmp(0x1015_fc36, 0x7); goto l_0x1015_fc36; /* jmp 0x1015fc36 */
        l_0x1015_fc2f:
            ii(0x1015_fc2f, 7); mov(memb[ds, 0x101c_391b], 0x1);        /* mov byte [0x101c391b], 0x1 */
        l_0x1015_fc36:
            ii(0x1015_fc36, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_fc38, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_fc3b, 5); call(0x1007_5f2c, -0xe_9d14);           /* call 0x10075f2c */
            ii(0x1015_fc40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_fc42, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_fc43, 1); pop(edi);                               /* pop edi */
            ii(0x1015_fc44, 1); pop(esi);                               /* pop esi */
            ii(0x1015_fc45, 1); pop(edx);                               /* pop edx */
            ii(0x1015_fc46, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_fc47, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_fc48, 1); ret();                                  /* ret */
        }
    }
}
