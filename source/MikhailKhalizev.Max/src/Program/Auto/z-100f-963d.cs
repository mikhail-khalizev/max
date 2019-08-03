using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7dd1c555-872f-4909-aab9-33cb457b25f6")]
        public void Method_100f_963d()
        {
            ii(0x100f_963d, 5); pushd(0xa0);                            /* push 0xa0 */
            ii(0x100f_9642, 5); calld(Definitions.sys_check_available_stack_size, 0x6c70b); /* call 0x10165d52 */
            ii(0x100f_9647, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_9648, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_9649, 1); pushd(edx);                             /* push edx */
            ii(0x100f_964a, 1); pushd(esi);                             /* push esi */
            ii(0x100f_964b, 1); pushd(edi);                             /* push edi */
            ii(0x100f_964c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_964d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_964f, 6); sub(esp, 0x80);                         /* sub esp, 0x80 */
            ii(0x100f_9655, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9657, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_965c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_9662, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100f_9667, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_9669, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x100f_966c, 5); calld(0x100f_62d9, -0x3398);            /* call 0x100f62d9 */
            ii(0x100f_9671, 8); cmp(memw_a32[ds, 0x101c_3900], 0);      /* cmp word [0x101c3900], 0x0 */
            ii(0x100f_9679, 6); if(jzd(0x100f_974b, 0xcc)) goto l_0x100f_974b; /* jz 0x100f974b */
            ii(0x100f_967f, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100f_9686, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100f_968d, 7); test(memb_a32[ds, 0x101c_3900], 0x1);   /* test byte [0x101c3900], 0x1 */
            ii(0x100f_9694, 2); if(jzd(0x100f_96b8, 0x22)) goto l_0x100f_96b8; /* jz 0x100f96b8 */
            ii(0x100f_9696, 7); cmp(memb_a32[ds, 0x1020_9508], 0);      /* cmp byte [0x10209508], 0x0 */
            ii(0x100f_969d, 2); if(jnzd(0x100f_96a8, 0x9)) goto l_0x100f_96a8; /* jnz 0x100f96a8 */
            ii(0x100f_969f, 7); cmp(memb_a32[ds, 0x1020_9488], 0);      /* cmp byte [0x10209488], 0x0 */
            ii(0x100f_96a6, 2); if(jzd(0x100f_96b1, 0x9)) goto l_0x100f_96b1; /* jz 0x100f96b1 */
        l_0x100f_96a8:
            ii(0x100f_96a8, 7); mov(memd_a32[ss, ebp - 0x2c], 0xffff_ffff); /* mov dword [ebp-0x2c], 0xffffffff */
            ii(0x100f_96af, 2); jmpd(0x100f_96b8, 0x7); goto l_0x100f_96b8; /* jmp 0x100f96b8 */
        l_0x100f_96b1:
            ii(0x100f_96b1, 7); xor(memb_a32[ds, 0x101c_3900], 0x1);    /* xor byte [0x101c3900], 0x1 */
        l_0x100f_96b8:
            ii(0x100f_96b8, 7); test(memb_a32[ds, 0x101c_3900], 0x2);   /* test byte [0x101c3900], 0x2 */
            ii(0x100f_96bf, 2); if(jzd(0x100f_96e3, 0x22)) goto l_0x100f_96e3; /* jz 0x100f96e3 */
            ii(0x100f_96c1, 7); cmp(memb_a32[ds, 0x1020_9510], 0);      /* cmp byte [0x10209510], 0x0 */
            ii(0x100f_96c8, 2); if(jnzd(0x100f_96d3, 0x9)) goto l_0x100f_96d3; /* jnz 0x100f96d3 */
            ii(0x100f_96ca, 7); cmp(memb_a32[ds, 0x1020_9490], 0);      /* cmp byte [0x10209490], 0x0 */
            ii(0x100f_96d1, 2); if(jzd(0x100f_96dc, 0x9)) goto l_0x100f_96dc; /* jz 0x100f96dc */
        l_0x100f_96d3:
            ii(0x100f_96d3, 7); mov(memd_a32[ss, ebp - 0x2c], 0x1);     /* mov dword [ebp-0x2c], 0x1 */
            ii(0x100f_96da, 2); jmpd(0x100f_96e3, 0x7); goto l_0x100f_96e3; /* jmp 0x100f96e3 */
        l_0x100f_96dc:
            ii(0x100f_96dc, 7); xor(memb_a32[ds, 0x101c_3900], 0x2);    /* xor byte [0x101c3900], 0x2 */
        l_0x100f_96e3:
            ii(0x100f_96e3, 7); test(memb_a32[ds, 0x101c_3900], 0x4);   /* test byte [0x101c3900], 0x4 */
            ii(0x100f_96ea, 2); if(jzd(0x100f_970e, 0x22)) goto l_0x100f_970e; /* jz 0x100f970e */
            ii(0x100f_96ec, 7); cmp(memb_a32[ds, 0x1020_950b], 0);      /* cmp byte [0x1020950b], 0x0 */
            ii(0x100f_96f3, 2); if(jnzd(0x100f_96fe, 0x9)) goto l_0x100f_96fe; /* jnz 0x100f96fe */
            ii(0x100f_96f5, 7); cmp(memb_a32[ds, 0x1020_948b], 0);      /* cmp byte [0x1020948b], 0x0 */
            ii(0x100f_96fc, 2); if(jzd(0x100f_9707, 0x9)) goto l_0x100f_9707; /* jz 0x100f9707 */
        l_0x100f_96fe:
            ii(0x100f_96fe, 7); mov(memd_a32[ss, ebp - 0x28], 0xffff_ffff); /* mov dword [ebp-0x28], 0xffffffff */
            ii(0x100f_9705, 2); jmpd(0x100f_970e, 0x7); goto l_0x100f_970e; /* jmp 0x100f970e */
        l_0x100f_9707:
            ii(0x100f_9707, 7); xor(memb_a32[ds, 0x101c_3900], 0x4);    /* xor byte [0x101c3900], 0x4 */
        l_0x100f_970e:
            ii(0x100f_970e, 7); test(memb_a32[ds, 0x101c_3900], 0x8);   /* test byte [0x101c3900], 0x8 */
            ii(0x100f_9715, 2); if(jzd(0x100f_9739, 0x22)) goto l_0x100f_9739; /* jz 0x100f9739 */
            ii(0x100f_9717, 7); cmp(memb_a32[ds, 0x1020_950d], 0);      /* cmp byte [0x1020950d], 0x0 */
            ii(0x100f_971e, 2); if(jnzd(0x100f_9729, 0x9)) goto l_0x100f_9729; /* jnz 0x100f9729 */
            ii(0x100f_9720, 7); cmp(memb_a32[ds, 0x1020_948d], 0);      /* cmp byte [0x1020948d], 0x0 */
            ii(0x100f_9727, 2); if(jzd(0x100f_9732, 0x9)) goto l_0x100f_9732; /* jz 0x100f9732 */
        l_0x100f_9729:
            ii(0x100f_9729, 7); mov(memd_a32[ss, ebp - 0x28], 0x1);     /* mov dword [ebp-0x28], 0x1 */
            ii(0x100f_9730, 2); jmpd(0x100f_9739, 0x7); goto l_0x100f_9739; /* jmp 0x100f9739 */
        l_0x100f_9732:
            ii(0x100f_9732, 7); xor(memb_a32[ds, 0x101c_3900], 0x8);    /* xor byte [0x101c3900], 0x8 */
        l_0x100f_9739:
            ii(0x100f_9739, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_973c, 6); mov(memw_a32[ds, 0x101c_3986], ax);     /* mov [0x101c3986], ax */
            ii(0x100f_9742, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100f_9745, 6); mov(memw_a32[ds, 0x101c_3988], ax);     /* mov [0x101c3988], ax */
        l_0x100f_974b:
            ii(0x100f_974b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_974e, 5); calld(0x100e_ad24, -0xea2f);            /* call 0x100ead24 */
            ii(0x100f_9753, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100f_9756, 5); calld(0x100e_a933, -0xee28);            /* call 0x100ea933 */
            ii(0x100f_975b, 2); test(al, al);                           /* test al, al */
            ii(0x100f_975d, 2); if(jnzd(0x100f_977a, 0x1b)) goto l_0x100f_977a; /* jnz 0x100f977a */
            ii(0x100f_975f, 10); mov(memd_a32[ds, 0x101c_38d4], 0);     /* mov dword [0x101c38d4], 0x0 */
            ii(0x100f_9769, 5); mov(edx, 0x101c_38d0);                  /* mov edx, 0x101c38d0 */
            ii(0x100f_976e, 5); mov(eax, 0x101c_38cc);                  /* mov eax, 0x101c38cc */
            ii(0x100f_9773, 5); calld(/* sys */ 0x1016_c298, 0x72b20);  /* call 0x1016c298 */
            ii(0x100f_9778, 2); jmpd(0x100f_9796, 0x1c); goto l_0x100f_9796; /* jmp 0x100f9796 */
        l_0x100f_977a:
            ii(0x100f_977a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_977c, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100f_977f, 5); mov(memd_a32[ds, 0x101c_38d4], eax);    /* mov [0x101c38d4], eax */
            ii(0x100f_9784, 4); movsx(eax, memw_a32[ss, ebp - 0x23]);   /* movsx eax, word [ebp-0x23] */
            ii(0x100f_9788, 5); mov(memd_a32[ds, 0x101c_38cc], eax);    /* mov [0x101c38cc], eax */
            ii(0x100f_978d, 4); movsx(eax, memw_a32[ss, ebp - 0x21]);   /* movsx eax, word [ebp-0x21] */
            ii(0x100f_9791, 5); mov(memd_a32[ds, 0x101c_38d0], eax);    /* mov [0x101c38d0], eax */
        l_0x100f_9796:
            ii(0x100f_9796, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9798, 5); calld(0x100e_883d, -0x10f60);           /* call 0x100e883d */
            ii(0x100f_979d, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_97a0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_97a3, 4); add(memd_a32[ss, ebp - 0x14], 0x1a);    /* add dword [ebp-0x14], 0x1a */
            ii(0x100f_97a7, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x100f_97ab, 2); jmpd(0x100f_97b7, 0xa); goto l_0x100f_97b7; /* jmp 0x100f97b7 */
        l_0x100f_97ad:
            ii(0x100f_97ad, 3); inc(memb_a32[ss, ebp - 0x4]);           /* inc byte [ebp-0x4] */
            ii(0x100f_97b0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_97b3, 4); add(memd_a32[ss, ebp - 0x14], 0x1a);    /* add dword [ebp-0x14], 0x1a */
        l_0x100f_97b7:
            ii(0x100f_97b7, 4); cmp(memb_a32[ss, ebp - 0x4], 0x3b);     /* cmp byte [ebp-0x4], 0x3b */
            ii(0x100f_97bb, 2); if(jzd(0x100f_97fe, 0x41)) goto l_0x100f_97fe; /* jz 0x100f97fe */
            ii(0x100f_97bd, 6); mov(edx, memd_a32[ds, 0x101c_38cc]);    /* mov edx, [0x101c38cc] */
            ii(0x100f_97c3, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_97c6, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x100f_97c8, 2); if(jld(0x100f_97d8, 0xe)) goto l_0x100f_97d8; /* jl 0x100f97d8 */
            ii(0x100f_97ca, 6); mov(edx, memd_a32[ds, 0x101c_38d0]);    /* mov edx, [0x101c38d0] */
            ii(0x100f_97d0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_97d3, 3); cmp(edx, memd_a32[ds, eax + 0x4]);      /* cmp edx, [eax+0x4] */
            ii(0x100f_97d6, 2); if(jged(0x100f_97da, 0x2)) goto l_0x100f_97da; /* jge 0x100f97da */
        l_0x100f_97d8:
            ii(0x100f_97d8, 2); jmpd(0x100f_97e8, 0xe); goto l_0x100f_97e8; /* jmp 0x100f97e8 */
        l_0x100f_97da:
            ii(0x100f_97da, 6); mov(edx, memd_a32[ds, 0x101c_38cc]);    /* mov edx, [0x101c38cc] */
            ii(0x100f_97e0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_97e3, 3); cmp(edx, memd_a32[ds, eax + 0x8]);      /* cmp edx, [eax+0x8] */
            ii(0x100f_97e6, 2); if(jled(0x100f_97ea, 0x2)) goto l_0x100f_97ea; /* jle 0x100f97ea */
        l_0x100f_97e8:
            ii(0x100f_97e8, 2); jmpd(0x100f_97f8, 0xe); goto l_0x100f_97f8; /* jmp 0x100f97f8 */
        l_0x100f_97ea:
            ii(0x100f_97ea, 6); mov(edx, memd_a32[ds, 0x101c_38d0]);    /* mov edx, [0x101c38d0] */
            ii(0x100f_97f0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_97f3, 3); cmp(edx, memd_a32[ds, eax + 0xc]);      /* cmp edx, [eax+0xc] */
            ii(0x100f_97f6, 2); if(jled(0x100f_97fa, 0x2)) goto l_0x100f_97fa; /* jle 0x100f97fa */
        l_0x100f_97f8:
            ii(0x100f_97f8, 2); jmpd(0x100f_97fc, 0x2); goto l_0x100f_97fc; /* jmp 0x100f97fc */
        l_0x100f_97fa:
            ii(0x100f_97fa, 2); jmpd(0x100f_97fe, 0x2); goto l_0x100f_97fe; /* jmp 0x100f97fe */
        l_0x100f_97fc:
            ii(0x100f_97fc, 2); jmpd(0x100f_97ad, -0x51); goto l_0x100f_97ad; /* jmp 0x100f97ad */
        l_0x100f_97fe:
            ii(0x100f_97fe, 4); cmp(memb_a32[ss, ebp - 0x4], 0x2);      /* cmp byte [ebp-0x4], 0x2 */
            ii(0x100f_9802, 2); if(jnzd(0x100f_9808, 0x4)) goto l_0x100f_9808; /* jnz 0x100f9808 */
            ii(0x100f_9804, 4); mov(memb_a32[ss, ebp - 0x4], 0x26);     /* mov byte [ebp-0x4], 0x26 */
        l_0x100f_9808:
            ii(0x100f_9808, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_980f, 2); if(jnzd(0x100f_9817, 0x6)) goto l_0x100f_9817; /* jnz 0x100f9817 */
            ii(0x100f_9811, 4); cmp(memb_a32[ss, ebp - 0x4], 0x26);     /* cmp byte [ebp-0x4], 0x26 */
            ii(0x100f_9815, 2); if(jnzd(0x100f_9819, 0x2)) goto l_0x100f_9819; /* jnz 0x100f9819 */
        l_0x100f_9817:
            ii(0x100f_9817, 2); jmpd(0x100f_981d, 0x4); goto l_0x100f_981d; /* jmp 0x100f981d */
        l_0x100f_9819:
            ii(0x100f_9819, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
        l_0x100f_981d:
            ii(0x100f_981d, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100f_9821, 5); calld(0x1012_1216, 0x279f0);            /* call 0x10121216 */
            ii(0x100f_9826, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100f_9829, 4); cmp(memb_a32[ss, ebp - 0x4], 0x26);     /* cmp byte [ebp-0x4], 0x26 */
            ii(0x100f_982d, 2); if(jnzd(0x100f_988d, 0x5e)) goto l_0x100f_988d; /* jnz 0x100f988d */
            ii(0x100f_982f, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_9834, 5); calld(0x100e_883d, -0x10ffc);           /* call 0x100e883d */
            ii(0x100f_9839, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_983c, 5); mov(eax, memd_a32[ds, 0x101c_38cc]);    /* mov eax, [0x101c38cc] */
            ii(0x100f_9841, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_9844, 2); sub(eax, memd_a32[ds, edx]);            /* sub eax, [edx] */
            ii(0x100f_9846, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x100f_984d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9850, 6); add(eax, memd_a32[ds, 0x101c_38ec]);    /* add eax, [0x101c38ec] */
            ii(0x100f_9856, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100f_9859, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100f_985c, 5); mov(eax, memd_a32[ds, 0x101c_38d0]);    /* mov eax, [0x101c38d0] */
            ii(0x100f_9861, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_9864, 3); sub(eax, memd_a32[ds, edx + 0x4]);      /* sub eax, [edx+0x4] */
            ii(0x100f_9867, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x100f_986e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9871, 6); add(eax, memd_a32[ds, 0x101c_38f0]);    /* add eax, [0x101c38f0] */
            ii(0x100f_9877, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100f_987a, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100f_987d, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x100f_9881, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100f_9885, 5); calld(0x100f_7fb2, -0x18d8);            /* call 0x100f7fb2 */
            ii(0x100f_988a, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x100f_988d:
            ii(0x100f_988d, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x100f_9891, 5); calld(0x1012_0d94, 0x274fe);            /* call 0x10120d94 */
            ii(0x100f_9896, 7); test(memb_a32[ds, 0x101c_38d4], 0x3);   /* test byte [0x101c38d4], 0x3 */
            ii(0x100f_989d, 6); if(jzd(0x100f_9950, 0xad)) goto l_0x100f_9950; /* jz 0x100f9950 */
            ii(0x100f_98a3, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_98a6, 5); mov(memb_a32[ds, 0x101c_38d8], al);     /* mov [0x101c38d8], al */
            ii(0x100f_98ab, 4); cmp(memb_a32[ss, ebp - 0x4], 0x26);     /* cmp byte [ebp-0x4], 0x26 */
            ii(0x100f_98af, 6); if(jnzd(0x100f_9950, 0x9b)) goto l_0x100f_9950; /* jnz 0x100f9950 */
            ii(0x100f_98b5, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_98ba, 5); calld(0x100e_883d, -0x11082);           /* call 0x100e883d */
            ii(0x100f_98bf, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_98c2, 6); mov(ax, memw_a32[ds, 0x101c_38cc]);     /* mov ax, [0x101c38cc] */
            ii(0x100f_98c8, 6); mov(memw_a32[ds, 0x101c_389a], ax);     /* mov [0x101c389a], ax */
            ii(0x100f_98ce, 6); mov(ax, memw_a32[ds, 0x101c_38d0]);     /* mov ax, [0x101c38d0] */
            ii(0x100f_98d4, 6); mov(memw_a32[ds, 0x101c_389c], ax);     /* mov [0x101c389c], ax */
            ii(0x100f_98da, 5); mov(eax, memd_a32[ds, 0x101c_38cc]);    /* mov eax, [0x101c38cc] */
            ii(0x100f_98df, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_98e2, 2); sub(eax, memd_a32[ds, edx]);            /* sub eax, [edx] */
            ii(0x100f_98e4, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x100f_98eb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_98ee, 6); add(eax, memd_a32[ds, 0x101c_38ec]);    /* add eax, [0x101c38ec] */
            ii(0x100f_98f4, 6); mov(memw_a32[ds, 0x101c_389e], ax);     /* mov [0x101c389e], ax */
            ii(0x100f_98fa, 5); mov(eax, memd_a32[ds, 0x101c_38d0]);    /* mov eax, [0x101c38d0] */
            ii(0x100f_98ff, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_9902, 3); sub(eax, memd_a32[ds, edx + 0x4]);      /* sub eax, [edx+0x4] */
            ii(0x100f_9905, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x100f_990c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_990f, 6); add(eax, memd_a32[ds, 0x101c_38f0]);    /* add eax, [0x101c38f0] */
            ii(0x100f_9915, 6); mov(memw_a32[ds, 0x101c_38a0], ax);     /* mov [0x101c38a0], ax */
            ii(0x100f_991b, 5); mov(eax, memd_a32[ds, 0x101c_389c]);    /* mov eax, [0x101c389c] */
            ii(0x100f_9920, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9923, 5); mov(memd_a32[ds, 0x101c_38ac], eax);    /* mov [0x101c38ac], eax */
            ii(0x100f_9928, 5); mov(eax, memd_a32[ds, 0x101c_38ac]);    /* mov eax, [0x101c38ac] */
            ii(0x100f_992d, 5); mov(memd_a32[ds, 0x101c_38a4], eax);    /* mov [0x101c38a4], eax */
            ii(0x100f_9932, 5); mov(eax, memd_a32[ds, 0x101c_389e]);    /* mov eax, [0x101c389e] */
            ii(0x100f_9937, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_993a, 5); mov(memd_a32[ds, 0x101c_38b0], eax);    /* mov [0x101c38b0], eax */
            ii(0x100f_993f, 5); mov(eax, memd_a32[ds, 0x101c_38b0]);    /* mov eax, [0x101c38b0] */
            ii(0x100f_9944, 5); mov(memd_a32[ds, 0x101c_38a8], eax);    /* mov [0x101c38a8], eax */
            ii(0x100f_9949, 7); mov(memb_a32[ds, 0x101c_38a2], 0x1);    /* mov byte [0x101c38a2], 0x1 */
        l_0x100f_9950:
            ii(0x100f_9950, 7); cmp(memd_a32[ds, 0x101c_38d4], 0);      /* cmp dword [0x101c38d4], 0x0 */
            ii(0x100f_9957, 2); if(jnzd(0x100f_9962, 0x9)) goto l_0x100f_9962; /* jnz 0x100f9962 */
            ii(0x100f_9959, 5); calld(/* sys */ 0x1016_c348, 0x729ea);  /* call 0x1016c348 */
            ii(0x100f_995e, 2); test(al, 0x4);                          /* test al, 0x4 */
            ii(0x100f_9960, 2); if(jnzd(0x100f_9964, 0x2)) goto l_0x100f_9964; /* jnz 0x100f9964 */
        l_0x100f_9962:
            ii(0x100f_9962, 2); jmpd(0x100f_996b, 0x7); goto l_0x100f_996b; /* jmp 0x100f996b */
        l_0x100f_9964:
            ii(0x100f_9964, 7); or(memb_a32[ds, 0x101c_38d4], 0x1);     /* or byte [0x101c38d4], 0x1 */
        l_0x100f_996b:
            ii(0x100f_996b, 7); cmp(memd_a32[ds, 0x101c_38d4], 0);      /* cmp dword [0x101c38d4], 0x0 */
            ii(0x100f_9972, 6); if(jzd(0x100f_99cf, 0x57)) goto l_0x100f_99cf; /* jz 0x100f99cf */
            ii(0x100f_9978, 5); mov(al, memb_a32[ds, 0x101c_38d8]);     /* mov al, [0x101c38d8] */
            ii(0x100f_997d, 3); cmp(al, memb_a32[ss, ebp - 0x4]);       /* cmp al, [ebp-0x4] */
            ii(0x100f_9980, 2); if(jzd(0x100f_99cf, 0x4d)) goto l_0x100f_99cf; /* jz 0x100f99cf */
            ii(0x100f_9982, 7); cmp(memb_a32[ds, 0x101c_38d8], 0x23);   /* cmp byte [0x101c38d8], 0x23 */
            ii(0x100f_9989, 2); if(jnzd(0x100f_9991, 0x6)) goto l_0x100f_9991; /* jnz 0x100f9991 */
            ii(0x100f_998b, 4); mov(memb_a32[ss, ebp - 0x4], 0x23);     /* mov byte [ebp-0x4], 0x23 */
            ii(0x100f_998f, 2); jmpd(0x100f_99cf, 0x3e); goto l_0x100f_99cf; /* jmp 0x100f99cf */
        l_0x100f_9991:
            ii(0x100f_9991, 7); cmp(memb_a32[ds, 0x101c_38d8], 0x27);   /* cmp byte [0x101c38d8], 0x27 */
            ii(0x100f_9998, 2); if(jld(0x100f_99a3, 0x9)) goto l_0x100f_99a3; /* jl 0x100f99a3 */
            ii(0x100f_999a, 7); cmp(memb_a32[ds, 0x101c_38d8], 0x32);   /* cmp byte [0x101c38d8], 0x32 */
            ii(0x100f_99a1, 2); if(jled(0x100f_99a5, 0x2)) goto l_0x100f_99a5; /* jle 0x100f99a5 */
        l_0x100f_99a3:
            ii(0x100f_99a3, 2); jmpd(0x100f_99ab, 0x6); goto l_0x100f_99ab; /* jmp 0x100f99ab */
        l_0x100f_99a5:
            ii(0x100f_99a5, 4); cmp(memb_a32[ss, ebp - 0x4], 0x27);     /* cmp byte [ebp-0x4], 0x27 */
            ii(0x100f_99a9, 2); if(jged(0x100f_99ad, 0x2)) goto l_0x100f_99ad; /* jge 0x100f99ad */
        l_0x100f_99ab:
            ii(0x100f_99ab, 2); jmpd(0x100f_99b3, 0x6); goto l_0x100f_99b3; /* jmp 0x100f99b3 */
        l_0x100f_99ad:
            ii(0x100f_99ad, 4); cmp(memb_a32[ss, ebp - 0x4], 0x32);     /* cmp byte [ebp-0x4], 0x32 */
            ii(0x100f_99b1, 2); if(jled(0x100f_99cf, 0x1c)) goto l_0x100f_99cf; /* jle 0x100f99cf */
        l_0x100f_99b3:
            ii(0x100f_99b3, 7); cmp(memb_a32[ds, 0x101c_38a2], 0);      /* cmp byte [0x101c38a2], 0x0 */
            ii(0x100f_99ba, 2); if(jzd(0x100f_99c5, 0x9)) goto l_0x100f_99c5; /* jz 0x100f99c5 */
            ii(0x100f_99bc, 7); test(memb_a32[ds, 0x101c_38d4], 0x3);   /* test byte [0x101c38d4], 0x3 */
            ii(0x100f_99c3, 2); if(jzd(0x100f_99cf, 0xa)) goto l_0x100f_99cf; /* jz 0x100f99cf */
        l_0x100f_99c5:
            ii(0x100f_99c5, 10); mov(memd_a32[ds, 0x101c_38d4], 0);     /* mov dword [0x101c38d4], 0x0 */
        l_0x100f_99cf:
            ii(0x100f_99cf, 7); test(memb_a32[ds, 0x101c_38d4], 0x30);  /* test byte [0x101c38d4], 0x30 */
            ii(0x100f_99d6, 2); if(jzd(0x100f_9a18, 0x40)) goto l_0x100f_9a18; /* jz 0x100f9a18 */
            ii(0x100f_99d8, 7); mov(memb_a32[ds, 0x101c_38d8], 0);      /* mov byte [0x101c38d8], 0x0 */
            ii(0x100f_99df, 7); cmp(memb_a32[ds, 0x101c_38a2], 0);      /* cmp byte [0x101c38a2], 0x0 */
            ii(0x100f_99e6, 2); if(jzd(0x100f_9a18, 0x30)) goto l_0x100f_9a18; /* jz 0x100f9a18 */
            ii(0x100f_99e8, 7); cmp(memb_a32[ds, 0x101c_38a2], 0x2);    /* cmp byte [0x101c38a2], 0x2 */
            ii(0x100f_99ef, 2); if(jnzd(0x100f_9a0a, 0x19)) goto l_0x100f_9a0a; /* jnz 0x100f9a0a */
            ii(0x100f_99f1, 5); mov(edx, 0x101c_38a4);                  /* mov edx, 0x101c38a4 */
            ii(0x100f_99f6, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_99fb, 5); calld(0x1007_6600, -0x83400);           /* call 0x10076600 */
            ii(0x100f_9a00, 5); calld(0x1007_5537, -0x844ce);           /* call 0x10075537 */
            ii(0x100f_9a05, 5); calld(0x100f_f5c1, 0x5bb7);             /* call 0x100ff5c1 */
        l_0x100f_9a0a:
            ii(0x100f_9a0a, 7); mov(memb_a32[ds, 0x101c_38a2], 0);      /* mov byte [0x101c38a2], 0x0 */
            ii(0x100f_9a11, 7); mov(memb_a32[ds, 0x101c_38a3], 0);      /* mov byte [0x101c38a3], 0x0 */
        l_0x100f_9a18:
            ii(0x100f_9a18, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_9a1b, 3); mov(memb_a32[ss, ebp - 0x38], al);      /* mov [ebp-0x38], al */
            ii(0x100f_9a1e, 5); jmpd(0x100f_9ae4, 0xc1); goto l_0x100f_9ae4; /* jmp 0x100f9ae4 */
        //  ii(0x100f_9a23, 142); Недостижимый код.
l_0x100f_9ab1:
            ii(0x100f_9ab1, 2); jmpd(0x100f_9b01, 0x4e); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        //  ii(0x100f_9ab3, 49); Недостижимый код.
l_0x100f_9ae4:
            ii(0x100f_9ae4, 3); mov(al, memb_a32[ss, ebp - 0x38]);      /* mov al, [ebp-0x38] */
            ii(0x100f_9ae7, 2); sub(al, 0x27);                          /* sub al, 0x27 */
            ii(0x100f_9ae9, 3); mov(memb_a32[ss, ebp - 0x3c], al);      /* mov [ebp-0x3c], al */
            ii(0x100f_9aec, 4); cmp(memb_a32[ss, ebp - 0x3c], 0xb);     /* cmp byte [ebp-0x3c], 0xb */
            ii(0x100f_9af0, 2); if(jad(0x100f_9ab1, -0x41)) goto l_0x100f_9ab1; /* ja 0x100f9ab1 */
            ii(0x100f_9af2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9af4, 3); mov(al, memb_a32[ss, ebp - 0x3c]);      /* mov al, [ebp-0x3c] */
            ii(0x100f_9af7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_9afa, 7); jmpd_abs(memd_a32[cs, eax + 0x100f_9ab4]); return; /* jmp dword [cs:eax+0x100f9ab4] */
        l_0x100f_9b01:
            ii(0x100f_9b01, 4); cmp(memb_a32[ss, ebp - 0x4], 0x26);     /* cmp byte [ebp-0x4], 0x26 */
            ii(0x100f_9b05, 2); if(jnzd(0x100f_9b27, 0x20)) goto l_0x100f_9b27; /* jnz 0x100f9b27 */
            ii(0x100f_9b07, 6); mov(ax, memw_a32[ds, 0x101c_3908]);     /* mov ax, [0x101c3908] */
            ii(0x100f_9b0d, 7); cmp(ax, memw_a32[ds, 0x101c_390c]);     /* cmp ax, [0x101c390c] */
            ii(0x100f_9b14, 2); if(jnzd(0x100f_9b25, 0xf)) goto l_0x100f_9b25; /* jnz 0x100f9b25 */
            ii(0x100f_9b16, 6); mov(ax, memw_a32[ds, 0x101c_390a]);     /* mov ax, [0x101c390a] */
            ii(0x100f_9b1c, 7); cmp(ax, memw_a32[ds, 0x101c_390e]);     /* cmp ax, [0x101c390e] */
            ii(0x100f_9b23, 2); if(jzd(0x100f_9b27, 0x2)) goto l_0x100f_9b27; /* jz 0x100f9b27 */
        l_0x100f_9b25:
            ii(0x100f_9b25, 2); jmpd(0x100f_9b29, 0x2); goto l_0x100f_9b29; /* jmp 0x100f9b29 */
        l_0x100f_9b27:
            ii(0x100f_9b27, 2); jmpd(0x100f_9b82, 0x59); goto l_0x100f_9b82; /* jmp 0x100f9b82 */
        l_0x100f_9b29:
            ii(0x100f_9b29, 6); mov(ax, memw_a32[ds, 0x101c_390a]);     /* mov ax, [0x101c390a] */
            ii(0x100f_9b2f, 1); inc(eax);                               /* inc eax */
            ii(0x100f_9b30, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_9b33, 6); mov(ax, memw_a32[ds, 0x101c_3908]);     /* mov ax, [0x101c3908] */
            ii(0x100f_9b39, 1); inc(eax);                               /* inc eax */
            ii(0x100f_9b3a, 1); cwde();                                 /* cwde */
            ii(0x100f_9b3b, 5); calld(0x100f_32a2, -0x689e);            /* call 0x100f32a2 */
            ii(0x100f_9b40, 7); cmp(memb_a32[ds, 0x101c_37d4], 0);      /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_9b47, 2); if(jzd(0x100f_9b6a, 0x21)) goto l_0x100f_9b6a; /* jz 0x100f9b6a */
            ii(0x100f_9b49, 6); mov(ebx, memd_a32[ds, 0x101c_3908]);    /* mov ebx, [0x101c3908] */
            ii(0x100f_9b4f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9b52, 6); mov(edx, memd_a32[ds, 0x101c_3906]);    /* mov edx, [0x101c3906] */
            ii(0x100f_9b58, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9b5b, 5); mov(eax, 0x101c_37c4);                  /* mov eax, 0x101c37c4 */
            ii(0x100f_9b60, 5); calld(0x1008_abbc, -0x6efa9);           /* call 0x1008abbc */
            ii(0x100f_9b65, 5); calld(0x1016_309a, 0x69530);            /* call 0x1016309a */
        l_0x100f_9b6a:
            ii(0x100f_9b6a, 6); mov(ax, memw_a32[ds, 0x101c_3908]);     /* mov ax, [0x101c3908] */
            ii(0x100f_9b70, 6); mov(memw_a32[ds, 0x101c_390c], ax);     /* mov [0x101c390c], ax */
            ii(0x100f_9b76, 6); mov(ax, memw_a32[ds, 0x101c_390a]);     /* mov ax, [0x101c390a] */
            ii(0x100f_9b7c, 6); mov(memw_a32[ds, 0x101c_390e], ax);     /* mov [0x101c390e], ax */
        l_0x100f_9b82:
            ii(0x100f_9b82, 7); cmp(memd_a32[ds, 0x101c_38d4], 0);      /* cmp dword [0x101c38d4], 0x0 */
            ii(0x100f_9b89, 6); if(jzd(0x100f_a7df, 0xc50)) goto l_0x100f_a7df; /* jz 0x100fa7df */
            ii(0x100f_9b8f, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100f_9b93, 5); calld(0x100e_883d, -0x1135b);           /* call 0x100e883d */
            ii(0x100f_9b98, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_9b9b, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_9b9e, 3); mov(memb_a32[ss, ebp - 0x40], al);      /* mov [ebp-0x40], al */
            ii(0x100f_9ba1, 5); jmpd(0x100f_a76e, 0xbc8); goto l_0x100f_a76e; /* jmp 0x100fa76e */
        l_0x100f_9ba6:
            ii(0x100f_9ba6, 5); jmpd(0x100f_a7df, 0xc34); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9bab:
            ii(0x100f_9bab, 7); test(memb_a32[ds, 0x101c_38d4], 0x10);  /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9bb2, 2); if(jzd(0x100f_9bb9, 0x5)) goto l_0x100f_9bb9; /* jz 0x100f9bb9 */
            ii(0x100f_9bb4, 5); calld(0x1011_606c, 0x1c4b3);            /* call 0x1011606c */
        l_0x100f_9bb9:
            ii(0x100f_9bb9, 5); jmpd(0x100f_a7df, 0xc21); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9bbe:
            ii(0x100f_9bbe, 7); test(memb_a32[ds, 0x101c_38d4], 0x10);  /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9bc5, 2); if(jzd(0x100f_9bf3, 0x2c)) goto l_0x100f_9bf3; /* jz 0x100f9bf3 */
            ii(0x100f_9bc7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_9bca, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100f_9bcd, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x100f_9bd0, 6); cmp(eax, memd_a32[ds, 0x101c_38d0]);    /* cmp eax, [0x101c38d0] */
            ii(0x100f_9bd6, 2); if(jgd(0x100f_9bf3, 0x1b)) goto l_0x100f_9bf3; /* jg 0x100f9bf3 */
            ii(0x100f_9bd8, 7); cmp(memb_a32[ds, 0x101c_3911], 0);      /* cmp byte [0x101c3911], 0x0 */
            ii(0x100f_9bdf, 2); if(jnzd(0x100f_9be7, 0x6)) goto l_0x100f_9be7; /* jnz 0x100f9be7 */
            ii(0x100f_9be1, 4); mov(memb_a32[ss, ebp - 0x44], 0x1);     /* mov byte [ebp-0x44], 0x1 */
            ii(0x100f_9be5, 2); jmpd(0x100f_9beb, 0x4); goto l_0x100f_9beb; /* jmp 0x100f9beb */
        l_0x100f_9be7:
            ii(0x100f_9be7, 4); mov(memb_a32[ss, ebp - 0x44], 0);       /* mov byte [ebp-0x44], 0x0 */
        l_0x100f_9beb:
            ii(0x100f_9beb, 3); mov(al, memb_a32[ss, ebp - 0x44]);      /* mov al, [ebp-0x44] */
            ii(0x100f_9bee, 5); mov(memb_a32[ds, 0x101c_3911], al);     /* mov [0x101c3911], al */
        l_0x100f_9bf3:
            ii(0x100f_9bf3, 5); jmpd(0x100f_a7df, 0xbe7); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9bf8:
            ii(0x100f_9bf8, 7); test(memb_a32[ds, 0x101c_38d4], 0x10);  /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9bff, 2); if(jzd(0x100f_9c1a, 0x19)) goto l_0x100f_9c1a; /* jz 0x100f9c1a */
            ii(0x100f_9c01, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_9c03, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9c05, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100f_9c0b, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100f_9c10, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_9c13, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9c15, 5); calld(0x1010_1620, 0x7a06);             /* call 0x10101620 */
        l_0x100f_9c1a:
            ii(0x100f_9c1a, 5); jmpd(0x100f_a7df, 0xbc0); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9c1f:
            ii(0x100f_9c1f, 7); test(memb_a32[ds, 0x101c_38d4], 0x10);  /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9c26, 2); if(jzd(0x100f_9c3f, 0x17)) goto l_0x100f_9c3f; /* jz 0x100f9c3f */
            ii(0x100f_9c28, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_9c2a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9c2c, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100f_9c32, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100f_9c35, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_9c38, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9c3a, 5); calld(0x1010_1620, 0x79e1);             /* call 0x10101620 */
        l_0x100f_9c3f:
            ii(0x100f_9c3f, 5); jmpd(0x100f_a7df, 0xb9b); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9c44:
            ii(0x100f_9c44, 7); test(memb_a32[ds, 0x101c_38d4], 0x1);   /* test byte [0x101c38d4], 0x1 */
            ii(0x100f_9c4b, 6); if(jzd(0x100f_a7df, 0xb8e)) goto l_0x100f_a7df; /* jz 0x100fa7df */
            ii(0x100f_9c51, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100f_9c56, 5); calld(0x100e_883d, -0x1141e);           /* call 0x100e883d */
            ii(0x100f_9c5b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_9c5e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_9c61, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_9c63, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x100f_9c66, 6); sub(memd_a32[ds, 0x101c_38cc], eax);    /* sub [0x101c38cc], eax */
            ii(0x100f_9c6c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_9c6f, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100f_9c73, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_9c76, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100f_9c79, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100f_9c7c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_9c7f, 7); cmp(memd_a32[ds, 0x101c_38cc], 0);      /* cmp dword [0x101c38cc], 0x0 */
            ii(0x100f_9c86, 2); if(jged(0x100f_9c92, 0xa)) goto l_0x100f_9c92; /* jge 0x100f9c92 */
            ii(0x100f_9c88, 10); mov(memd_a32[ds, 0x101c_38cc], 0);     /* mov dword [0x101c38cc], 0x0 */
        l_0x100f_9c92:
            ii(0x100f_9c92, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_9c96, 6); cmp(eax, memd_a32[ds, 0x101c_38cc]);    /* cmp eax, [0x101c38cc] */
            ii(0x100f_9c9c, 2); if(jged(0x100f_9ca7, 0x9)) goto l_0x100f_9ca7; /* jge 0x100f9ca7 */
            ii(0x100f_9c9e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_9ca2, 5); mov(memd_a32[ds, 0x101c_38cc], eax);    /* mov [0x101c38cc], eax */
        l_0x100f_9ca7:
            ii(0x100f_9ca7, 7); imul(edx, memd_a32[ds, 0x101c_38cc], 0x3c); /* imul edx, [0x101c38cc], 0x3c */
            ii(0x100f_9cae, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100f_9cb2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_9cb4, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_9cb7, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_9cb9, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100f_9cbe, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_9cc0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_9cc2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_9cc5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_9cc7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9cc9, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_9ccd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9ccf, 5); calld(0x1010_1620, 0x794c);             /* call 0x10101620 */
            ii(0x100f_9cd4, 5); jmpd(0x100f_a7df, 0xb06); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9cd9:
            ii(0x100f_9cd9, 6); mov(ax, memw_a32[ds, 0x101c_38cc]);     /* mov ax, [0x101c38cc] */
            ii(0x100f_9cdf, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_9ce2, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100f_9ce5, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100f_9ce8, 6); mov(ax, memw_a32[ds, 0x101c_38d0]);     /* mov ax, [0x101c38d0] */
            ii(0x100f_9cee, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_9cf1, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x100f_9cf5, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100f_9cf8, 6); mov(ebx, memd_a32[ds, 0x101c_8170]);    /* mov ebx, [0x101c8170] */
            ii(0x100f_9cfe, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9d01, 1); dec(ebx);                               /* dec ebx */
            ii(0x100f_9d02, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9d04, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x100f_9d08, 5); calld(0x1007_6e7c, -0x82e91);           /* call 0x10076e7c */
            ii(0x100f_9d0d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_9d0f, 5); calld(Definitions.my_min, -0x70590);    /* call 0x10089784 */
            ii(0x100f_9d14, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100f_9d17, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100f_9d1c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9d1f, 3); lea(ebx, eax - 0x1);                    /* lea ebx, [eax-0x1] */
            ii(0x100f_9d22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9d24, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100f_9d28, 5); calld(0x1007_6e7c, -0x82eb1);           /* call 0x10076e7c */
            ii(0x100f_9d2d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_9d2f, 5); calld(Definitions.my_min, -0x705b0);    /* call 0x10089784 */
            ii(0x100f_9d34, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100f_9d37, 7); cmp(memb_a32[ds, 0x101c_37d0], 0);      /* cmp byte [0x101c37d0], 0x0 */
            ii(0x100f_9d3e, 2); if(jzd(0x100f_9d6a, 0x2a)) goto l_0x100f_9d6a; /* jz 0x100f9d6a */
            ii(0x100f_9d40, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x100f_9d44, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_9d46, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_9d48, 5); mov(eax, memd_a32[ds, 0x101c_38e4]);    /* mov eax, [0x101c38e4] */
            ii(0x100f_9d4d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9d50, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_9d52, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100f_9d55, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100f_9d59, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_9d5b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_9d5d, 5); mov(eax, memd_a32[ds, 0x101c_38e6]);    /* mov eax, [0x101c38e6] */
            ii(0x100f_9d62, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9d65, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_9d67, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
        l_0x100f_9d6a:
            ii(0x100f_9d6a, 7); test(memb_a32[ds, 0x101c_38d4], 0x11);  /* test byte [0x101c38d4], 0x11 */
            ii(0x100f_9d71, 2); if(jzd(0x100f_9d93, 0x20)) goto l_0x100f_9d93; /* jz 0x100f9d93 */
            ii(0x100f_9d73, 5); calld(0x1010_2acc, 0x8d54);             /* call 0x10102acc */
            ii(0x100f_9d78, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_9d7a, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_9d7c, 4); movsx(ebx, memw_a32[ss, ebp - 0x4c]);   /* movsx ebx, word [ebp-0x4c] */
            ii(0x100f_9d80, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x100f_9d84, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_9d89, 5); calld(0x1010_1620, 0x7892);             /* call 0x10101620 */
            ii(0x100f_9d8e, 5); jmpd(0x100f_9e10, 0x7d); goto l_0x100f_9e10; /* jmp 0x100f9e10 */
        l_0x100f_9d93:
            ii(0x100f_9d93, 7); test(memb_a32[ds, 0x101c_38d4], 0x20);  /* test byte [0x101c38d4], 0x20 */
            ii(0x100f_9d9a, 6); if(jzd(0x100f_9e10, 0x70)) goto l_0x100f_9e10; /* jz 0x100f9e10 */
            ii(0x100f_9da0, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x100f_9da4, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x100f_9da8, 5); calld(0x100f_7fb2, -0x1dfb);            /* call 0x100f7fb2 */
            ii(0x100f_9dad, 3); mov(memb_a32[ss, ebp - 0x50], al);      /* mov [ebp-0x50], al */
            ii(0x100f_9db0, 4); cmp(memb_a32[ss, ebp - 0x50], 0x14);    /* cmp byte [ebp-0x50], 0x14 */
            ii(0x100f_9db4, 2); if(jzd(0x100f_9dbc, 0x6)) goto l_0x100f_9dbc; /* jz 0x100f9dbc */
            ii(0x100f_9db6, 4); cmp(memb_a32[ss, ebp - 0x50], 0x16);    /* cmp byte [ebp-0x50], 0x16 */
            ii(0x100f_9dba, 2); if(jnzd(0x100f_9e10, 0x54)) goto l_0x100f_9e10; /* jnz 0x100f9e10 */
        l_0x100f_9dbc:
            ii(0x100f_9dbc, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_9dc1, 5); calld(0x1007_6574, -0x83852);           /* call 0x10076574 */
            ii(0x100f_9dc6, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100f_9dca, 2); if(jzd(0x100f_9e10, 0x44)) goto l_0x100f_9e10; /* jz 0x100f9e10 */
            ii(0x100f_9dcc, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100f_9dd0, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100f_9dd3, 3); pushd(memd_a32[ss, ebp - 0x54]);        /* push dword [ebp-0x54] */
            ii(0x100f_9dd6, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x100f_9dda, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100f_9ddd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_9de2, 5); calld(0x1007_65d0, -0x83817);           /* call 0x100765d0 */
            ii(0x100f_9de7, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100f_9dea, 4); cmp(memb_a32[ss, ebp - 0x50], 0x14);    /* cmp byte [ebp-0x50], 0x14 */
            ii(0x100f_9dee, 2); if(jnzd(0x100f_9df6, 0x6)) goto l_0x100f_9df6; /* jnz 0x100f9df6 */
            ii(0x100f_9df0, 4); mov(memb_a32[ss, ebp - 0x60], 0);       /* mov byte [ebp-0x60], 0x0 */
            ii(0x100f_9df4, 2); jmpd(0x100f_9dfa, 0x4); goto l_0x100f_9dfa; /* jmp 0x100f9dfa */
        l_0x100f_9df6:
            ii(0x100f_9df6, 4); mov(memb_a32[ss, ebp - 0x60], 0x1c);    /* mov byte [ebp-0x60], 0x1c */
        l_0x100f_9dfa:
            ii(0x100f_9dfa, 3); mov(edx, memd_a32[ss, ebp - 0x63]);     /* mov edx, [ebp-0x63] */
            ii(0x100f_9dfd, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100f_9e00, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_9e05, 3); mov(ecx, memd_a32[ss, ebp - 0x58]);     /* mov ecx, [ebp-0x58] */
            ii(0x100f_9e08, 3); mov(ebx, memd_a32[ss, ebp - 0x5c]);     /* mov ebx, [ebp-0x5c] */
            ii(0x100f_9e0b, 5); calld(0x100f_79d4, -0x243c);            /* call 0x100f79d4 */
        l_0x100f_9e10:
            ii(0x100f_9e10, 5); jmpd(0x100f_a7df, 0x9ca); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9e15:
            ii(0x100f_9e15, 7); test(memb_a32[ds, 0x101c_38d4], 0x3);   /* test byte [0x101c38d4], 0x3 */
            ii(0x100f_9e1c, 6); if(jnzd(0x100f_a7df, 0x9bd)) goto l_0x100f_a7df; /* jnz 0x100fa7df */
            ii(0x100f_9e22, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100f_9e27, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_9e2c, 5); calld(0x1013_dc59, 0x43e28);            /* call 0x1013dc59 */
            ii(0x100f_9e31, 7); cmp(memb_a32[ds, 0x101c_391d], 0);      /* cmp byte [0x101c391d], 0x0 */
            ii(0x100f_9e38, 2); if(jzd(0x100f_9e3f, 0x5)) goto l_0x100f_9e3f; /* jz 0x100f9e3f */
            ii(0x100f_9e3a, 5); calld(0x1011_606c, 0x1c22d);            /* call 0x1011606c */
        l_0x100f_9e3f:
            ii(0x100f_9e3f, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_9e46, 6); if(jnzd(0x100f_9efd, 0xb1)) goto l_0x100f_9efd; /* jnz 0x100f9efd */
            ii(0x100f_9e4c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9e4e, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9e53, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_9e56, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_9e5d, 7); mov(memw_a32[ds, eax + 0x101c_35bc], dx); /* mov [eax+0x101c35bc], dx */
            ii(0x100f_9e64, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9e66, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9e6b, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_9e6e, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_9e75, 7); mov(memw_a32[ds, eax + 0x101c_35be], dx); /* mov [eax+0x101c35be], dx */
            ii(0x100f_9e7c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9e7e, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9e83, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_9e89, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_9e90, 7); mov(memw_a32[ds, eax + 0x101c_a56c], dx); /* mov [eax+0x101ca56c], dx */
            ii(0x100f_9e97, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9e99, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9e9e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_9ea4, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_9eab, 7); mov(memw_a32[ds, eax + 0x101c_a56e], dx); /* mov [eax+0x101ca56e], dx */
            ii(0x100f_9eb2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9eb4, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9eb9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_9ebf, 9); mov(memw_a32[ds, eax + 0x101c_a56a], 0x40); /* mov word [eax+0x101ca56a], 0x40 */
            ii(0x100f_9ec8, 5); calld(0x1012_11ea, 0x2731d);            /* call 0x101211ea */
            ii(0x100f_9ecd, 2); cmp(al, 0x14);                          /* cmp al, 0x14 */
            ii(0x100f_9ecf, 2); if(jnzd(0x100f_9ee9, 0x18)) goto l_0x100f_9ee9; /* jnz 0x100f9ee9 */
            ii(0x100f_9ed1, 7); mov(memb_a32[ds, 0x101c_391e], 0xd);    /* mov byte [0x101c391e], 0xd */
            ii(0x100f_9ed8, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x100f_9edd, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_9ee2, 5); calld(0x1013_dc59, 0x43d72);            /* call 0x1013dc59 */
            ii(0x100f_9ee7, 2); jmpd(0x100f_9ef8, 0xf); goto l_0x100f_9ef8; /* jmp 0x100f9ef8 */
        l_0x100f_9ee9:
            ii(0x100f_9ee9, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100f_9eee, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_9ef3, 5); calld(0x1013_dc59, 0x43d61);            /* call 0x1013dc59 */
        l_0x100f_9ef8:
            ii(0x100f_9ef8, 5); jmpd(0x100f_a7df, 0x8e2); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9efd:
            ii(0x100f_9efd, 5); mov(ecx, 0x40_0000);                    /* mov ecx, 0x400000 */
            ii(0x100f_9f02, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9f04, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_9f09, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_9f0c, 6); mov(edx, memd_a32[ds, 0x101c_3908]);    /* mov edx, [0x101c3908] */
            ii(0x100f_9f12, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9f15, 5); mov(eax, memd_a32[ds, 0x101c_3906]);    /* mov eax, [0x101c3906] */
            ii(0x100f_9f1a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9f1d, 5); calld(0x1007_388b, -0x86697);           /* call 0x1007388b */
            ii(0x100f_9f22, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_9f25, 7); cmp(memb_a32[ds, 0x101c_37d4], 0);      /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_9f2c, 6); if(jzd(0x100f_9ffe, 0xcc)) goto l_0x100f_9ffe; /* jz 0x100f9ffe */
            ii(0x100f_9f32, 7); test(memb_a32[ds, 0x101c_38d4], 0x20);  /* test byte [0x101c38d4], 0x20 */
            ii(0x100f_9f39, 2); if(jzd(0x100f_9f77, 0x3c)) goto l_0x100f_9f77; /* jz 0x100f9f77 */
            ii(0x100f_9f3b, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_9f3f, 2); if(jnzd(0x100f_9f5a, 0x19)) goto l_0x100f_9f5a; /* jnz 0x100f9f5a */
            ii(0x100f_9f41, 6); mov(edx, memd_a32[ds, 0x101c_3908]);    /* mov edx, [0x101c3908] */
            ii(0x100f_9f47, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9f4a, 5); mov(eax, memd_a32[ds, 0x101c_3906]);    /* mov eax, [0x101c3906] */
            ii(0x100f_9f4f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9f52, 5); calld(0x1007_3c18, -0x8633f);           /* call 0x10073c18 */
            ii(0x100f_9f57, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100f_9f5a:
            ii(0x100f_9f5a, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_9f5e, 2); if(jzd(0x100f_9f72, 0x12)) goto l_0x100f_9f72; /* jz 0x100f9f72 */
            ii(0x100f_9f60, 5); mov(ebx, 0x1a);                         /* mov ebx, 0x1a */
            ii(0x100f_9f65, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_9f6a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_9f6d, 5); calld(0x1016_3053, 0x690e1);            /* call 0x10163053 */
        l_0x100f_9f72:
            ii(0x100f_9f72, 5); jmpd(0x100f_a7df, 0x868); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9f77:
            ii(0x100f_9f77, 6); mov(ebx, memd_a32[ds, 0x101c_3908]);    /* mov ebx, [0x101c3908] */
            ii(0x100f_9f7d, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9f80, 6); mov(edx, memd_a32[ds, 0x101c_3906]);    /* mov edx, [0x101c3906] */
            ii(0x100f_9f86, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9f89, 5); mov(eax, 0x101c_37c4);                  /* mov eax, 0x101c37c4 */
            ii(0x100f_9f8e, 5); calld(0x1008_abbc, -0x6f3d7);           /* call 0x1008abbc */
            ii(0x100f_9f93, 5); calld(0x1016_30fa, 0x69162);            /* call 0x101630fa */
            ii(0x100f_9f98, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_9f9a, 6); if(jzd(0x100f_a7df, 0x83f)) goto l_0x100f_a7df; /* jz 0x100fa7df */
            ii(0x100f_9fa0, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_9fa7, 2); if(jzd(0x100f_9fd1, 0x28)) goto l_0x100f_9fd1; /* jz 0x100f9fd1 */
            ii(0x100f_9fa9, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_9faf, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_9fb2, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_9fb8, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9fbb, 6); mov(edx, memd_a32[ds, 0x101c_37d4]);    /* mov edx, [0x101c37d4] */
            ii(0x100f_9fc1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9fc4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9fc6, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_9fcb, 1); cwde();                                 /* cwde */
            ii(0x100f_9fcc, 5); calld(0x1012_90e7, 0x2f116);            /* call 0x101290e7 */
        l_0x100f_9fd1:
            ii(0x100f_9fd1, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_9fd7, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_9fda, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_9fe0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9fe3, 6); mov(edx, memd_a32[ds, 0x101c_37d4]);    /* mov edx, [0x101c37d4] */
            ii(0x100f_9fe9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9fec, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9fee, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_9ff3, 1); cwde();                                 /* cwde */
            ii(0x100f_9ff4, 5); calld(0x1010_2119, 0x8120);             /* call 0x10102119 */
            ii(0x100f_9ff9, 5); jmpd(0x100f_a7df, 0x7e1); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_9ffe:
            ii(0x100f_9ffe, 5); mov(ecx, 0x40_0000);                    /* mov ecx, 0x400000 */
            ii(0x100f_a003, 6); mov(ebx, memd_a32[ds, 0x101c_3908]);    /* mov ebx, [0x101c3908] */
            ii(0x100f_a009, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a00c, 6); mov(edx, memd_a32[ds, 0x101c_3906]);    /* mov edx, [0x101c3906] */
            ii(0x100f_a012, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_a015, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_a017, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_a01c, 1); cwde();                                 /* cwde */
            ii(0x100f_a01d, 5); calld(0x1007_459a, -0x85a88);           /* call 0x1007459a */
            ii(0x100f_a022, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_a025, 7); test(memb_a32[ds, 0x101c_38d4], 0x20);  /* test byte [0x101c38d4], 0x20 */
            ii(0x100f_a02c, 6); if(jzd(0x100f_a13a, 0x108)) goto l_0x100f_a13a; /* jz 0x100fa13a */
            ii(0x100f_a032, 5); calld(0x100f_40a6, -0x5f91);            /* call 0x100f40a6 */
            ii(0x100f_a037, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a039, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a03e, 5); calld(0x1013_ad71, 0x40d2e);            /* call 0x1013ad71 */
            ii(0x100f_a043, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a045, 2); if(jzd(0x100f_a06b, 0x24)) goto l_0x100f_a06b; /* jz 0x100fa06b */
            ii(0x100f_a047, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_a04a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a04f, 5); calld(0x1007_6e00, -0x83254);           /* call 0x10076e00 */
            ii(0x100f_a054, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a056, 2); if(jnzd(0x100f_a069, 0x11)) goto l_0x100f_a069; /* jnz 0x100fa069 */
            ii(0x100f_a058, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a05b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a060, 5); calld(0x1007_6e00, -0x83265);           /* call 0x10076e00 */
            ii(0x100f_a065, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a067, 2); if(jzd(0x100f_a06b, 0x2)) goto l_0x100f_a06b; /* jz 0x100fa06b */
        l_0x100f_a069:
            ii(0x100f_a069, 2); jmpd(0x100f_a06d, 0x2); goto l_0x100f_a06d; /* jmp 0x100fa06d */
        l_0x100f_a06b:
            ii(0x100f_a06b, 2); jmpd(0x100f_a081, 0x14); goto l_0x100f_a081; /* jmp 0x100fa081 */
        l_0x100f_a06d:
            ii(0x100f_a06d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a072, 5); calld(0x1008_abbc, -0x6f4bb);           /* call 0x1008abbc */
            ii(0x100f_a077, 5); calld(0x1014_0d43, 0x46cc7);            /* call 0x10140d43 */
            ii(0x100f_a07c, 5); jmpd(0x100f_a135, 0xb4); goto l_0x100f_a135; /* jmp 0x100fa135 */
        l_0x100f_a081:
            ii(0x100f_a081, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_a085, 2); if(jzd(0x100f_a094, 0xd)) goto l_0x100f_a094; /* jz 0x100fa094 */
            ii(0x100f_a087, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_a08a, 5); calld(0x100f_92fe, -0xd91);             /* call 0x100f92fe */
            ii(0x100f_a08f, 5); jmpd(0x100f_a135, 0xa1); goto l_0x100f_a135; /* jmp 0x100fa135 */
        l_0x100f_a094:
            ii(0x100f_a094, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_a098, 2); if(jzd(0x100f_a0ec, 0x52)) goto l_0x100f_a0ec; /* jz 0x100fa0ec */
            ii(0x100f_a09a, 7); cmp(memb_a32[ds, 0x101c_388c], 0);      /* cmp byte [0x101c388c], 0x0 */
            ii(0x100f_a0a1, 2); if(jzd(0x100f_a0c6, 0x23)) goto l_0x100f_a0c6; /* jz 0x100fa0c6 */
            ii(0x100f_a0a3, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a0a6, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_a0ab, 5); calld(0x1008_aab4, -0x6f5fc);           /* call 0x1008aab4 */
            ii(0x100f_a0b0, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a0b2, 2); if(jzd(0x100f_a0b9, 0x5)) goto l_0x100f_a0b9; /* jz 0x100fa0b9 */
            ii(0x100f_a0b4, 5); calld(0x100f_f5c1, 0x5508);             /* call 0x100ff5c1 */
        l_0x100f_a0b9:
            ii(0x100f_a0b9, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a0bc, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_a0c1, 5); calld(0x1008_ab1c, -0x6f5aa);           /* call 0x1008ab1c */
        l_0x100f_a0c6:
            ii(0x100f_a0c6, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a0cc, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a0cf, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a0d5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a0d8, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100f_a0db, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a0e0, 5); calld(0x1007_65d0, -0x83b15);           /* call 0x100765d0 */
            ii(0x100f_a0e5, 5); calld(0x100f_927b, -0xe6f);             /* call 0x100f927b */
            ii(0x100f_a0ea, 2); jmpd(0x100f_a135, 0x49); goto l_0x100f_a135; /* jmp 0x100fa135 */
        l_0x100f_a0ec:
            ii(0x100f_a0ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a0ee, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a0f3, 5); calld(0x1013_ad71, 0x40c79);            /* call 0x1013ad71 */
            ii(0x100f_a0f8, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a0fa, 2); if(jzd(0x100f_a135, 0x39)) goto l_0x100f_a135; /* jz 0x100fa135 */
            ii(0x100f_a0fc, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a101, 5); calld(0x1007_6574, -0x83b92);           /* call 0x10076574 */
            ii(0x100f_a106, 4); mov(memb_a32[ds, eax + 0x55], 0);       /* mov byte [eax+0x55], 0x0 */
            ii(0x100f_a10a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a10f, 5); calld(0x1007_6574, -0x83ba0);           /* call 0x10076574 */
            ii(0x100f_a114, 4); mov(memb_a32[ds, eax + 0x56], 0);       /* mov byte [eax+0x56], 0x0 */
            ii(0x100f_a118, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a11d, 5); calld(0x1007_6574, -0x83bae);           /* call 0x10076574 */
            ii(0x100f_a122, 4); mov(memb_a32[ds, eax + 0x57], 0);       /* mov byte [eax+0x57], 0x0 */
            ii(0x100f_a126, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a12b, 5); calld(0x1007_65d0, -0x83b60);           /* call 0x100765d0 */
            ii(0x100f_a130, 5); calld(0x1010_094d, 0x6818);             /* call 0x1010094d */
        l_0x100f_a135:
            ii(0x100f_a135, 5); jmpd(0x100f_a7df, 0x6a5); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_a13a:
            ii(0x100f_a13a, 5); calld(0x1012_11ea, 0x270ab);            /* call 0x101211ea */
            ii(0x100f_a13f, 3); mov(memb_a32[ss, ebp - 0x64], al);      /* mov [ebp-0x64], al */
            ii(0x100f_a142, 5); jmpd(0x100f_a740, 0x5f9); goto l_0x100f_a740; /* jmp 0x100fa740 */
        //  ii(0x100f_a147, 1461); Недостижимый код.
l_0x100f_a6fc:
            ii(0x100f_a6fc, 2); jmpd(0x100f_a75d, 0x5f); goto l_0x100f_a75d; /* jmp 0x100fa75d */
        //  ii(0x100f_a6fe, 66); Недостижимый код.
l_0x100f_a740:
            ii(0x100f_a740, 3); mov(al, memb_a32[ss, ebp - 0x64]);      /* mov al, [ebp-0x64] */
            ii(0x100f_a743, 2); sub(al, 0xc);                           /* sub al, 0xc */
            ii(0x100f_a745, 3); mov(memb_a32[ss, ebp - 0x7c], al);      /* mov [ebp-0x7c], al */
            ii(0x100f_a748, 4); cmp(memb_a32[ss, ebp - 0x7c], 0xf);     /* cmp byte [ebp-0x7c], 0xf */
            ii(0x100f_a74c, 2); if(jad(0x100f_a6fc, -0x52)) goto l_0x100f_a6fc; /* ja 0x100fa6fc */
            ii(0x100f_a74e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_a750, 3); mov(al, memb_a32[ss, ebp - 0x7c]);      /* mov al, [ebp-0x7c] */
            ii(0x100f_a753, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_a756, 7); jmpd_abs(memd_a32[cs, eax + 0x100f_a700]); return; /* jmp dword [cs:eax+0x100fa700] */
        l_0x100f_a75d:
            ii(0x100f_a75d, 5); jmpd(0x100f_a7df, 0x7d); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_a762:
            ii(0x100f_a762, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_a764, 5); calld(0x100f_448c, -0x62dd);            /* call 0x100f448c */
            ii(0x100f_a769, 5); jmpd(0x100f_a7df, 0x71); goto l_0x100f_a7df; /* jmp 0x100fa7df */
        l_0x100f_a76e:
            ii(0x100f_a76e, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x100f_a771, 3); mov(memb_a32[ss, ebp - 0x80], al);      /* mov [ebp-0x80], al */
            ii(0x100f_a774, 4); cmp(memb_a32[ss, ebp - 0x80], 0x16);    /* cmp byte [ebp-0x80], 0x16 */
            ii(0x100f_a778, 2); if(jbd(0x100f_a7b7, 0x3d)) goto l_0x100f_a7b7; /* jb 0x100fa7b7 */
            ii(0x100f_a77a, 4); cmp(memb_a32[ss, ebp - 0x80], 0x16);    /* cmp byte [ebp-0x80], 0x16 */
            ii(0x100f_a77e, 6); if(jbed(0x100f_9bf8, -0xb8c)) goto l_0x100f_9bf8; /* jbe 0x100f9bf8 */
            ii(0x100f_a784, 4); cmp(memb_a32[ss, ebp - 0x80], 0x18);    /* cmp byte [ebp-0x80], 0x18 */
            ii(0x100f_a788, 2); if(jbd(0x100f_a7b2, 0x28)) goto l_0x100f_a7b2; /* jb 0x100fa7b2 */
            ii(0x100f_a78a, 4); cmp(memb_a32[ss, ebp - 0x80], 0x18);    /* cmp byte [ebp-0x80], 0x18 */
            ii(0x100f_a78e, 6); if(jbed(0x100f_9c1f, -0xb75)) goto l_0x100f_9c1f; /* jbe 0x100f9c1f */
            ii(0x100f_a794, 4); cmp(memb_a32[ss, ebp - 0x80], 0x23);    /* cmp byte [ebp-0x80], 0x23 */
            ii(0x100f_a798, 2); if(jbd(0x100f_a7b0, 0x16)) goto l_0x100f_a7b0; /* jb 0x100fa7b0 */
            ii(0x100f_a79a, 4); cmp(memb_a32[ss, ebp - 0x80], 0x23);    /* cmp byte [ebp-0x80], 0x23 */
            ii(0x100f_a79e, 6); if(jbed(0x100f_9cd9, -0xacb)) goto l_0x100f_9cd9; /* jbe 0x100f9cd9 */
            ii(0x100f_a7a4, 4); cmp(memb_a32[ss, ebp - 0x80], 0x26);    /* cmp byte [ebp-0x80], 0x26 */
            ii(0x100f_a7a8, 6); if(jzd(0x100f_9e15, -0x999)) goto l_0x100f_9e15; /* jz 0x100f9e15 */
            ii(0x100f_a7ae, 2); jmpd(0x100f_a762, -0x4e); goto l_0x100f_a762; /* jmp 0x100fa762 */
        l_0x100f_a7b0:
            ii(0x100f_a7b0, 2); jmpd(0x100f_a762, -0x50); goto l_0x100f_a762; /* jmp 0x100fa762 */
        l_0x100f_a7b2:
            ii(0x100f_a7b2, 5); jmpd(0x100f_9c44, -0xb73); goto l_0x100f_9c44; /* jmp 0x100f9c44 */
        l_0x100f_a7b7:
            ii(0x100f_a7b7, 4); cmp(memb_a32[ss, ebp - 0x80], 0x2);     /* cmp byte [ebp-0x80], 0x2 */
            ii(0x100f_a7bb, 2); if(jbd(0x100f_a7d3, 0x16)) goto l_0x100f_a7d3; /* jb 0x100fa7d3 */
            ii(0x100f_a7bd, 4); cmp(memb_a32[ss, ebp - 0x80], 0x2);     /* cmp byte [ebp-0x80], 0x2 */
            ii(0x100f_a7c1, 6); if(jbed(0x100f_9bab, -0xc1c)) goto l_0x100f_9bab; /* jbe 0x100f9bab */
            ii(0x100f_a7c7, 4); cmp(memb_a32[ss, ebp - 0x80], 0x6);     /* cmp byte [ebp-0x80], 0x6 */
            ii(0x100f_a7cb, 6); if(jzd(0x100f_9bbe, -0xc13)) goto l_0x100f_9bbe; /* jz 0x100f9bbe */
            ii(0x100f_a7d1, 2); jmpd(0x100f_a762, -0x71); goto l_0x100f_a762; /* jmp 0x100fa762 */
        l_0x100f_a7d3:
            ii(0x100f_a7d3, 4); cmp(memb_a32[ss, ebp - 0x80], 0x1);     /* cmp byte [ebp-0x80], 0x1 */
            ii(0x100f_a7d7, 6); if(jzd(0x100f_9ba6, -0xc37)) goto l_0x100f_9ba6; /* jz 0x100f9ba6 */
            ii(0x100f_a7dd, 2); jmpd(0x100f_a762, -0x7d); goto l_0x100f_a762; /* jmp 0x100fa762 */
        l_0x100f_a7df:
            ii(0x100f_a7df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_a7e1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_a7e2, 1); popd(edi);                              /* pop edi */
            ii(0x100f_a7e3, 1); popd(esi);                              /* pop esi */
            ii(0x100f_a7e4, 1); popd(edx);                              /* pop edx */
            ii(0x100f_a7e5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_a7e6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_a7e7, 1); retd(); return;                         /* ret */
        }
    }
}
