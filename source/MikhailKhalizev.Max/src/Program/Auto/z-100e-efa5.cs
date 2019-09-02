using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_efa5-2d3c3d1e")]
        public void Method_100e_efa5()
        {
            ii(0x100e_efa5, 5); push(0x50);                             /* push 0x50 */
            ii(0x100e_efaa, 5); call(Definitions.sys_check_available_stack_size, 0x7_6da3); /* call 0x10165d52 */
            ii(0x100e_efaf, 1); push(ecx);                              /* push ecx */
            ii(0x100e_efb0, 1); push(esi);                              /* push esi */
            ii(0x100e_efb1, 1); push(edi);                              /* push edi */
            ii(0x100e_efb2, 1); push(ebp);                              /* push ebp */
            ii(0x100e_efb3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_efb5, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100e_efbb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_efbe, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100e_efc1, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100e_efc4, 6); mov(ax, memw[ds, 0x101c_3968]);         /* mov ax, [0x101c3968] */
            ii(0x100e_efca, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_efcd, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_efd4, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100e_efdb, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_efe2, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100e_efe9, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_efed, 2); if(jz(0x100e_effe, 0xf)) goto l_0x100e_effe; /* jz 0x100eeffe */
            ii(0x100e_efef, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100e_eff3, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100e_eff7, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_eff9, 3); cmp(edx, 5);                            /* cmp edx, 0x5 */
            ii(0x100e_effc, 2); if(jge(0x100e_f000, 2)) goto l_0x100e_f000; /* jge 0x100ef000 */
        l_0x100e_effe:
            ii(0x100e_effe, 2); jmp(0x100e_f010, 0x10); goto l_0x100e_f010; /* jmp 0x100ef010 */
        l_0x100e_f000:
            ii(0x100e_f000, 7); mov(memb[ds, 0x101c_391e], 3);          /* mov byte [0x101c391e], 0x3 */
            ii(0x100e_f007, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100e_f00b, 5); jmp(0x100e_f2dc, 0x2cc); goto l_0x100e_f2dc; /* jmp 0x100ef2dc */
        l_0x100e_f010:
            ii(0x100e_f010, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100e_f017, 2); jmp(0x100e_f01f, 6); goto l_0x100e_f01f; /* jmp 0x100ef01f */
        l_0x100e_f019:
            ii(0x100e_f019, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100e_f01c, 3); inc(memd[ss, ebp - 0x28]);              /* inc dword [ebp-0x28] */
        l_0x100e_f01f:
            ii(0x100e_f01f, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f023, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100e_f026, 6); if(jge(0x100e_f0d0, 0xa4)) goto l_0x100e_f0d0; /* jge 0x100ef0d0 */
            ii(0x100e_f02c, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f030, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_f036, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100e_f03c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_f041, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_f043, 6); if(jz(0x100e_f0cb, 0x82)) goto l_0x100e_f0cb; /* jz 0x100ef0cb */
            ii(0x100e_f049, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_f04c, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
            ii(0x100e_f04f, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f053, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_f059, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100e_f05f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_f064, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100e_f067, 2); if(jz(0x100e_f06f, 6)) goto l_0x100e_f06f; /* jz 0x100ef06f */
            ii(0x100e_f069, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_f06c, 3); inc(memd[ss, ebp - 0x20]);              /* inc dword [ebp-0x20] */
        l_0x100e_f06f:
            ii(0x100e_f06f, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f073, 5); call(0x100e_c1bd, -0x2ebb);             /* call 0x100ec1bd */
            ii(0x100e_f078, 2); test(al, al);                           /* test al, al */
            ii(0x100e_f07a, 2); if(jz(0x100e_f096, 0x1a)) goto l_0x100e_f096; /* jz 0x100ef096 */
            ii(0x100e_f07c, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f080, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_f086, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100e_f08c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_f091, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100e_f094, 2); if(jnz(0x100e_f098, 2)) goto l_0x100e_f098; /* jnz 0x100ef098 */
        l_0x100e_f096:
            ii(0x100e_f096, 2); jmp(0x100e_f0cb, 0x33); goto l_0x100e_f0cb; /* jmp 0x100ef0cb */
        l_0x100e_f098:
            ii(0x100e_f098, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f09c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_f0a2, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100e_f0a8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_f0ad, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100e_f0b0, 2); if(jz(0x100e_f0b8, 6)) goto l_0x100e_f0b8; /* jz 0x100ef0b8 */
            ii(0x100e_f0b2, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_f0b5, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x100e_f0b8:
            ii(0x100e_f0b8, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_f0bb, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
            ii(0x100e_f0be, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_f0c1, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100e_f0c3, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100e_f0c6, 5); mov(memw[ds, edx + ebp - 0x30], ax);    /* mov [edx+ebp-0x30], ax */
        l_0x100e_f0cb:
            ii(0x100e_f0cb, 5); jmp(0x100e_f019, -0xb7); goto l_0x100e_f019; /* jmp 0x100ef019 */
        l_0x100e_f0d0:
            ii(0x100e_f0d0, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100e_f0d4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_f0d6, 5); call(0x100e_cd4d, -0x238e);             /* call 0x100ecd4d */
            ii(0x100e_f0db, 3); mov(memb[ss, ebp - 0x34], al);          /* mov [ebp-0x34], al */
            ii(0x100e_f0de, 4); cmp(memb[ss, ebp - 0x34], 2);           /* cmp byte [ebp-0x34], 0x2 */
            ii(0x100e_f0e2, 2); if(jz(0x100e_f0ea, 6)) goto l_0x100e_f0ea; /* jz 0x100ef0ea */
            ii(0x100e_f0e4, 4); cmp(memb[ss, ebp - 0x34], 3);           /* cmp byte [ebp-0x34], 0x3 */
            ii(0x100e_f0e8, 2); if(jnz(0x100e_f108, 0x1e)) goto l_0x100e_f108; /* jnz 0x100ef108 */
        l_0x100e_f0ea:
            ii(0x100e_f0ea, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100e_f0ef, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_f0f3, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_f0f7, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100e_f0fa, 5); call(0x100e_e881, -0x87e);              /* call 0x100ee881 */
            ii(0x100e_f0ff, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100e_f103, 5); jmp(0x100e_f2dc, 0x1d4); goto l_0x100e_f2dc; /* jmp 0x100ef2dc */
        l_0x100e_f108:
            ii(0x100e_f108, 4); cmp(memb[ss, ebp - 0x34], 1);           /* cmp byte [ebp-0x34], 0x1 */
            ii(0x100e_f10c, 2); if(jz(0x100e_f140, 0x32)) goto l_0x100e_f140; /* jz 0x100ef140 */
            ii(0x100e_f10e, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_f112, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100e_f115, 2); if(jnz(0x100e_f120, 9)) goto l_0x100e_f120; /* jnz 0x100ef120 */
            ii(0x100e_f117, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_f11b, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100e_f11e, 2); if(jg(0x100e_f122, 2)) goto l_0x100e_f122; /* jg 0x100ef122 */
        l_0x100e_f120:
            ii(0x100e_f120, 2); jmp(0x100e_f140, 0x1e); goto l_0x100e_f140; /* jmp 0x100ef140 */
        l_0x100e_f122:
            ii(0x100e_f122, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100e_f127, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_f12b, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_f12f, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100e_f132, 5); call(0x100e_e881, -0x8b6);              /* call 0x100ee881 */
            ii(0x100e_f137, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100e_f13b, 5); jmp(0x100e_f2dc, 0x19c); goto l_0x100e_f2dc; /* jmp 0x100ef2dc */
        l_0x100e_f140:
            ii(0x100e_f140, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_f144, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_f146, 2); if(jz(0x100e_f159, 0x11)) goto l_0x100e_f159; /* jz 0x100ef159 */
            ii(0x100e_f148, 5); cmp(memw[ss, ebp - 0x1c], 0);           /* cmp word [ebp-0x1c], 0x0 */
            ii(0x100e_f14d, 2); if(jnz(0x100e_f157, 8)) goto l_0x100e_f157; /* jnz 0x100ef157 */
            ii(0x100e_f14f, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100e_f153, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_f155, 2); if(jg(0x100e_f159, 2)) goto l_0x100e_f159; /* jg 0x100ef159 */
        l_0x100e_f157:
            ii(0x100e_f157, 2); jmp(0x100e_f177, 0x1e); goto l_0x100e_f177; /* jmp 0x100ef177 */
        l_0x100e_f159:
            ii(0x100e_f159, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100e_f15e, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_f162, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_f166, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100e_f169, 5); call(0x100e_e881, -0x8ed);              /* call 0x100ee881 */
            ii(0x100e_f16e, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100e_f172, 5); jmp(0x100e_f2dc, 0x165); goto l_0x100e_f2dc; /* jmp 0x100ef2dc */
        l_0x100e_f177:
            ii(0x100e_f177, 5); mov(eax, memd[ds, 0x101c_3964]);        /* mov eax, [0x101c3964] */
            ii(0x100e_f17c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_f17f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_f181, 2); if(jnz(0x100e_f1d4, 0x51)) goto l_0x100e_f1d4; /* jnz 0x100ef1d4 */
            ii(0x100e_f183, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_f187, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100e_f18b, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100e_f18e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_f190, 2); if(jnz(0x100e_f19a, 8)) goto l_0x100e_f19a; /* jnz 0x100ef19a */
            ii(0x100e_f192, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100e_f196, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_f198, 2); if(jg(0x100e_f19c, 2)) goto l_0x100e_f19c; /* jg 0x100ef19c */
        l_0x100e_f19a:
            ii(0x100e_f19a, 2); jmp(0x100e_f1a8, 0xc); goto l_0x100e_f1a8; /* jmp 0x100ef1a8 */
        l_0x100e_f19c:
            ii(0x100e_f19c, 5); mov(eax, StringDefinitions.NoticeGameWillEndIn10Turns); /* mov eax, 0x101a1fc4 */
            ii(0x100e_f1a1, 5); call(0x1011_6b06, 0x2_7960);            /* call 0x10116b06 */
            ii(0x100e_f1a6, 2); jmp(0x100e_f1cf, 0x27); goto l_0x100e_f1cf; /* jmp 0x100ef1cf */
        l_0x100e_f1a8:
            ii(0x100e_f1a8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_f1ab, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100e_f1af, 2); if(jl(0x100e_f1cf, 0x1e)) goto l_0x100e_f1cf; /* jl 0x100ef1cf */
            ii(0x100e_f1b1, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100e_f1b6, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_f1ba, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_f1be, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100e_f1c1, 5); call(0x100e_e881, -0x945);              /* call 0x100ee881 */
            ii(0x100e_f1c6, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100e_f1ca, 5); jmp(0x100e_f2dc, 0x10d); goto l_0x100e_f2dc; /* jmp 0x100ef2dc */
        l_0x100e_f1cf:
            ii(0x100e_f1cf, 5); jmp(0x100e_f23d, 0x69); goto l_0x100e_f23d; /* jmp 0x100ef23d */
        l_0x100e_f1d4:
            ii(0x100e_f1d4, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100e_f1db, 2); jmp(0x100e_f1e3, 6); goto l_0x100e_f1e3; /* jmp 0x100ef1e3 */
        l_0x100e_f1dd:
            ii(0x100e_f1dd, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100e_f1e0, 3); inc(memd[ss, ebp - 0x28]);              /* inc dword [ebp-0x28] */
        l_0x100e_f1e3:
            ii(0x100e_f1e3, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f1e7, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100e_f1ea, 2); if(jge(0x100e_f23d, 0x51)) goto l_0x100e_f23d; /* jge 0x100ef23d */
            ii(0x100e_f1ec, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f1f0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_f1f6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100e_f1fc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_f201, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_f203, 2); if(jz(0x100e_f21b, 0x16)) goto l_0x100e_f21b; /* jz 0x100ef21b */
            ii(0x100e_f205, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f209, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_f20f, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100e_f213, 6); cmp(edx, memd[ds, eax + 0x101c_a550]);  /* cmp edx, [eax+0x101ca550] */
            ii(0x100e_f219, 2); if(jle(0x100e_f21d, 2)) goto l_0x100e_f21d; /* jle 0x100ef21d */
        l_0x100e_f21b:
            ii(0x100e_f21b, 2); jmp(0x100e_f23b, 0x1e); goto l_0x100e_f23b; /* jmp 0x100ef23b */
        l_0x100e_f21d:
            ii(0x100e_f21d, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100e_f222, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_f226, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_f22a, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100e_f22d, 5); call(0x100e_e881, -0x9b1);              /* call 0x100ee881 */
            ii(0x100e_f232, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100e_f236, 5); jmp(0x100e_f2dc, 0xa1); goto l_0x100e_f2dc; /* jmp 0x100ef2dc */
        l_0x100e_f23b:
            ii(0x100e_f23b, 2); jmp(0x100e_f1dd, -0x60); goto l_0x100e_f1dd; /* jmp 0x100ef1dd */
        l_0x100e_f23d:
            ii(0x100e_f23d, 4); cmp(memb[ss, ebp - 0x34], 0);           /* cmp byte [ebp-0x34], 0x0 */
            ii(0x100e_f241, 6); if(jnz(0x100e_f2d8, 0x91)) goto l_0x100e_f2d8; /* jnz 0x100ef2d8 */
            ii(0x100e_f247, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100e_f24e, 2); jmp(0x100e_f256, 6); goto l_0x100e_f256; /* jmp 0x100ef256 */
        l_0x100e_f250:
            ii(0x100e_f250, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100e_f253, 3); inc(memd[ss, ebp - 0x28]);              /* inc dword [ebp-0x28] */
        l_0x100e_f256:
            ii(0x100e_f256, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f25a, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100e_f25d, 6); if(jge(0x100e_f2d8, 0x75)) goto l_0x100e_f2d8; /* jge 0x100ef2d8 */
            ii(0x100e_f263, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f267, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_f26d, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100e_f273, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_f278, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100e_f27b, 2); if(jnz(0x100e_f28a, 0xd)) goto l_0x100e_f28a; /* jnz 0x100ef28a */
            ii(0x100e_f27d, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f281, 5); call(0x100e_c1bd, -0x30c9);             /* call 0x100ec1bd */
            ii(0x100e_f286, 2); test(al, al);                           /* test al, al */
            ii(0x100e_f288, 2); if(jz(0x100e_f28c, 2)) goto l_0x100e_f28c; /* jz 0x100ef28c */
        l_0x100e_f28a:
            ii(0x100e_f28a, 2); jmp(0x100e_f2d3, 0x47); goto l_0x100e_f2d3; /* jmp 0x100ef2d3 */
        l_0x100e_f28c:
            ii(0x100e_f28c, 5); mov(al, memb[ds, 0x101c_391e]);         /* mov al, [0x101c391e] */
            ii(0x100e_f291, 3); mov(memb[ss, ebp - 0x38], al);          /* mov [ebp-0x38], al */
            ii(0x100e_f294, 5); mov(al, memb[ds, 0x101c_5624]);         /* mov al, [0x101c5624] */
            ii(0x100e_f299, 3); mov(memb[ss, ebp - 0x3c], al);          /* mov [ebp-0x3c], al */
            ii(0x100e_f29c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100e_f29e, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_f2a2, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_f2a6, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100e_f2a9, 5); call(0x100e_e881, -0xa2d);              /* call 0x100ee881 */
            ii(0x100e_f2ae, 4); cmp(memb[ss, ebp - 0x3c], 0);           /* cmp byte [ebp-0x3c], 0x0 */
            ii(0x100e_f2b2, 2); if(jz(0x100e_f2ba, 6)) goto l_0x100e_f2ba; /* jz 0x100ef2ba */
            ii(0x100e_f2b4, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100e_f2b8, 2); jmp(0x100e_f2dc, 0x22); goto l_0x100e_f2dc; /* jmp 0x100ef2dc */
        l_0x100e_f2ba:
            ii(0x100e_f2ba, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x100e_f2bd, 5); mov(memb[ds, 0x101c_391e], al);         /* mov [0x101c391e], al */
            ii(0x100e_f2c2, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100e_f2c6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_f2cc, 7); mov(memb[ds, eax + 0x101c_a490], 4);    /* mov byte [eax+0x101ca490], 0x4 */
        l_0x100e_f2d3:
            ii(0x100e_f2d3, 5); jmp(0x100e_f250, -0x88); goto l_0x100e_f250; /* jmp 0x100ef250 */
        l_0x100e_f2d8:
            ii(0x100e_f2d8, 4); mov(memb[ss, ebp - 0x24], 0);           /* mov byte [ebp-0x24], 0x0 */
        l_0x100e_f2dc:
            ii(0x100e_f2dc, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x100e_f2df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f2e1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_f2e2, 1); pop(edi);                               /* pop edi */
            ii(0x100e_f2e3, 1); pop(esi);                               /* pop esi */
            ii(0x100e_f2e4, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_f2e5, 1); ret();                                  /* ret */
        }
    }
}
