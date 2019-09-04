using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_963d-447acac9")]
        public void Method_100f_963d()
        {
            ii(0x100f_963d, 5); push(0xa0);                             /* push 0xa0 */
            ii(0x100f_9642, 5); call(Definitions.sys_check_available_stack_size, 0x6_c70b); /* call 0x10165d52 */
            ii(0x100f_9647, 1); push(ebx);                              /* push ebx */
            ii(0x100f_9648, 1); push(ecx);                              /* push ecx */
            ii(0x100f_9649, 1); push(edx);                              /* push edx */
            ii(0x100f_964a, 1); push(esi);                              /* push esi */
            ii(0x100f_964b, 1); push(edi);                              /* push edi */
            ii(0x100f_964c, 1); push(ebp);                              /* push ebp */
            ii(0x100f_964d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_964f, 6); sub(esp, 0x80);                         /* sub esp, 0x80 */
            ii(0x100f_9655, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9657, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_965c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_9662, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100f_9667, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_9669, 3); mov(memd[ss, ebp - 28], edx);           /* mov [ebp-0x1c], edx */
            ii(0x100f_966c, 5); call(0x100f_62d9, -0x3398);             /* call 0x100f62d9 */
            ii(0x100f_9671, 8); cmp(memw[ds, 0x101c_3900], 0);          /* cmp word [0x101c3900], 0x0 */
            ii(0x100f_9679, 6); if(jz(0x100f_974b, 0xcc)) goto l_0x100f_974b; /* jz 0x100f974b */
            ii(0x100f_967f, 7); mov(memd[ss, ebp - 40], 0);             /* mov dword [ebp-0x28], 0x0 */
            ii(0x100f_9686, 7); mov(memd[ss, ebp - 44], 0);             /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100f_968d, 7); test(memb[ds, 0x101c_3900], 1);         /* test byte [0x101c3900], 0x1 */
            ii(0x100f_9694, 2); if(jz(0x100f_96b8, 0x22)) goto l_0x100f_96b8; /* jz 0x100f96b8 */
            ii(0x100f_9696, 7); cmp(memb[ds, 0x1020_9508], 0);          /* cmp byte [0x10209508], 0x0 */
            ii(0x100f_969d, 2); if(jnz(0x100f_96a8, 9)) goto l_0x100f_96a8; /* jnz 0x100f96a8 */
            ii(0x100f_969f, 7); cmp(memb[ds, 0x1020_9488], 0);          /* cmp byte [0x10209488], 0x0 */
            ii(0x100f_96a6, 2); if(jz(0x100f_96b1, 9)) goto l_0x100f_96b1; /* jz 0x100f96b1 */
        l_0x100f_96a8:
            ii(0x100f_96a8, 7); mov(memd[ss, ebp - 44], 0xffff_ffff);   /* mov dword [ebp-0x2c], 0xffffffff */
            ii(0x100f_96af, 2); jmp(0x100f_96b8, 7); goto l_0x100f_96b8; /* jmp 0x100f96b8 */
        l_0x100f_96b1:
            ii(0x100f_96b1, 7); xor(memb[ds, 0x101c_3900], 1);          /* xor byte [0x101c3900], 0x1 */
        l_0x100f_96b8:
            ii(0x100f_96b8, 7); test(memb[ds, 0x101c_3900], 2);         /* test byte [0x101c3900], 0x2 */
            ii(0x100f_96bf, 2); if(jz(0x100f_96e3, 0x22)) goto l_0x100f_96e3; /* jz 0x100f96e3 */
            ii(0x100f_96c1, 7); cmp(memb[ds, 0x1020_9510], 0);          /* cmp byte [0x10209510], 0x0 */
            ii(0x100f_96c8, 2); if(jnz(0x100f_96d3, 9)) goto l_0x100f_96d3; /* jnz 0x100f96d3 */
            ii(0x100f_96ca, 7); cmp(memb[ds, 0x1020_9490], 0);          /* cmp byte [0x10209490], 0x0 */
            ii(0x100f_96d1, 2); if(jz(0x100f_96dc, 9)) goto l_0x100f_96dc; /* jz 0x100f96dc */
        l_0x100f_96d3:
            ii(0x100f_96d3, 7); mov(memd[ss, ebp - 44], 1);             /* mov dword [ebp-0x2c], 0x1 */
            ii(0x100f_96da, 2); jmp(0x100f_96e3, 7); goto l_0x100f_96e3; /* jmp 0x100f96e3 */
        l_0x100f_96dc:
            ii(0x100f_96dc, 7); xor(memb[ds, 0x101c_3900], 2);          /* xor byte [0x101c3900], 0x2 */
        l_0x100f_96e3:
            ii(0x100f_96e3, 7); test(memb[ds, 0x101c_3900], 4);         /* test byte [0x101c3900], 0x4 */
            ii(0x100f_96ea, 2); if(jz(0x100f_970e, 0x22)) goto l_0x100f_970e; /* jz 0x100f970e */
            ii(0x100f_96ec, 7); cmp(memb[ds, 0x1020_950b], 0);          /* cmp byte [0x1020950b], 0x0 */
            ii(0x100f_96f3, 2); if(jnz(0x100f_96fe, 9)) goto l_0x100f_96fe; /* jnz 0x100f96fe */
            ii(0x100f_96f5, 7); cmp(memb[ds, 0x1020_948b], 0);          /* cmp byte [0x1020948b], 0x0 */
            ii(0x100f_96fc, 2); if(jz(0x100f_9707, 9)) goto l_0x100f_9707; /* jz 0x100f9707 */
        l_0x100f_96fe:
            ii(0x100f_96fe, 7); mov(memd[ss, ebp - 40], 0xffff_ffff);   /* mov dword [ebp-0x28], 0xffffffff */
            ii(0x100f_9705, 2); jmp(0x100f_970e, 7); goto l_0x100f_970e; /* jmp 0x100f970e */
        l_0x100f_9707:
            ii(0x100f_9707, 7); xor(memb[ds, 0x101c_3900], 4);          /* xor byte [0x101c3900], 0x4 */
        l_0x100f_970e:
            ii(0x100f_970e, 7); test(memb[ds, 0x101c_3900], 8);         /* test byte [0x101c3900], 0x8 */
            ii(0x100f_9715, 2); if(jz(0x100f_9739, 0x22)) goto l_0x100f_9739; /* jz 0x100f9739 */
            ii(0x100f_9717, 7); cmp(memb[ds, 0x1020_950d], 0);          /* cmp byte [0x1020950d], 0x0 */
            ii(0x100f_971e, 2); if(jnz(0x100f_9729, 9)) goto l_0x100f_9729; /* jnz 0x100f9729 */
            ii(0x100f_9720, 7); cmp(memb[ds, 0x1020_948d], 0);          /* cmp byte [0x1020948d], 0x0 */
            ii(0x100f_9727, 2); if(jz(0x100f_9732, 9)) goto l_0x100f_9732; /* jz 0x100f9732 */
        l_0x100f_9729:
            ii(0x100f_9729, 7); mov(memd[ss, ebp - 40], 1);             /* mov dword [ebp-0x28], 0x1 */
            ii(0x100f_9730, 2); jmp(0x100f_9739, 7); goto l_0x100f_9739; /* jmp 0x100f9739 */
        l_0x100f_9732:
            ii(0x100f_9732, 7); xor(memb[ds, 0x101c_3900], 8);          /* xor byte [0x101c3900], 0x8 */
        l_0x100f_9739:
            ii(0x100f_9739, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100f_973c, 6); mov(memw[ds, 0x101c_3986], ax);         /* mov [0x101c3986], ax */
            ii(0x100f_9742, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100f_9745, 6); mov(memw[ds, 0x101c_3988], ax);         /* mov [0x101c3988], ax */
        l_0x100f_974b:
            ii(0x100f_974b, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x100f_974e, 5); call(0x100e_ad24, -0xea2f);             /* call 0x100ead24 */
            ii(0x100f_9753, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x100f_9756, 5); call(0x100e_a933, -0xee28);             /* call 0x100ea933 */
            ii(0x100f_975b, 2); test(al, al);                           /* test al, al */
            ii(0x100f_975d, 2); if(jnz(0x100f_977a, 0x1b)) goto l_0x100f_977a; /* jnz 0x100f977a */
            ii(0x100f_975f, 10); mov(memd[ds, 0x101c_38d4], 0);         /* mov dword [0x101c38d4], 0x0 */
            ii(0x100f_9769, 5); mov(edx, 0x101c_38d0);                  /* mov edx, 0x101c38d0 */
            ii(0x100f_976e, 5); mov(eax, 0x101c_38cc);                  /* mov eax, 0x101c38cc */
            ii(0x100f_9773, 5); call(/* sys */ 0x1016_c298, 0x7_2b20);  /* call 0x1016c298 */
            ii(0x100f_9778, 2); jmp(0x100f_9796, 0x1c); goto l_0x100f_9796; /* jmp 0x100f9796 */
        l_0x100f_977a:
            ii(0x100f_977a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_977c, 3); mov(al, memb[ss, ebp - 36]);            /* mov al, [ebp-0x24] */
            ii(0x100f_977f, 5); mov(memd[ds, 0x101c_38d4], eax);        /* mov [0x101c38d4], eax */
            ii(0x100f_9784, 4); movsx(eax, memw[ss, ebp - 35]);         /* movsx eax, word [ebp-0x23] */
            ii(0x100f_9788, 5); mov(memd[ds, 0x101c_38cc], eax);        /* mov [0x101c38cc], eax */
            ii(0x100f_978d, 4); movsx(eax, memw[ss, ebp - 33]);         /* movsx eax, word [ebp-0x21] */
            ii(0x100f_9791, 5); mov(memd[ds, 0x101c_38d0], eax);        /* mov [0x101c38d0], eax */
        l_0x100f_9796:
            ii(0x100f_9796, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9798, 5); call(0x100e_883d, -0x1_0f60);           /* call 0x100e883d */
            ii(0x100f_979d, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_97a0, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_97a3, 4); add(memd[ss, ebp - 20], 0x1a);          /* add dword [ebp-0x14], 0x1a */
            ii(0x100f_97a7, 4); mov(memb[ss, ebp - 4], 1);              /* mov byte [ebp-0x4], 0x1 */
            ii(0x100f_97ab, 2); jmp(0x100f_97b7, 0xa); goto l_0x100f_97b7; /* jmp 0x100f97b7 */
        l_0x100f_97ad:
            ii(0x100f_97ad, 3); inc(memb[ss, ebp - 4]);                 /* inc byte [ebp-0x4] */
            ii(0x100f_97b0, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_97b3, 4); add(memd[ss, ebp - 20], 0x1a);          /* add dword [ebp-0x14], 0x1a */
        l_0x100f_97b7:
            ii(0x100f_97b7, 4); cmp(memb[ss, ebp - 4], 0x3b);           /* cmp byte [ebp-0x4], 0x3b */
            ii(0x100f_97bb, 2); if(jz(0x100f_97fe, 0x41)) goto l_0x100f_97fe; /* jz 0x100f97fe */
            ii(0x100f_97bd, 6); mov(edx, memd[ds, 0x101c_38cc]);        /* mov edx, [0x101c38cc] */
            ii(0x100f_97c3, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_97c6, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x100f_97c8, 2); if(jl(0x100f_97d8, 0xe)) goto l_0x100f_97d8; /* jl 0x100f97d8 */
            ii(0x100f_97ca, 6); mov(edx, memd[ds, 0x101c_38d0]);        /* mov edx, [0x101c38d0] */
            ii(0x100f_97d0, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_97d3, 3); cmp(edx, memd[ds, eax + 4]);            /* cmp edx, [eax+0x4] */
            ii(0x100f_97d6, 2); if(jge(0x100f_97da, 2)) goto l_0x100f_97da; /* jge 0x100f97da */
        l_0x100f_97d8:
            ii(0x100f_97d8, 2); jmp(0x100f_97e8, 0xe); goto l_0x100f_97e8; /* jmp 0x100f97e8 */
        l_0x100f_97da:
            ii(0x100f_97da, 6); mov(edx, memd[ds, 0x101c_38cc]);        /* mov edx, [0x101c38cc] */
            ii(0x100f_97e0, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_97e3, 3); cmp(edx, memd[ds, eax + 8]);            /* cmp edx, [eax+0x8] */
            ii(0x100f_97e6, 2); if(jle(0x100f_97ea, 2)) goto l_0x100f_97ea; /* jle 0x100f97ea */
        l_0x100f_97e8:
            ii(0x100f_97e8, 2); jmp(0x100f_97f8, 0xe); goto l_0x100f_97f8; /* jmp 0x100f97f8 */
        l_0x100f_97ea:
            ii(0x100f_97ea, 6); mov(edx, memd[ds, 0x101c_38d0]);        /* mov edx, [0x101c38d0] */
            ii(0x100f_97f0, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_97f3, 3); cmp(edx, memd[ds, eax + 12]);           /* cmp edx, [eax+0xc] */
            ii(0x100f_97f6, 2); if(jle(0x100f_97fa, 2)) goto l_0x100f_97fa; /* jle 0x100f97fa */
        l_0x100f_97f8:
            ii(0x100f_97f8, 2); jmp(0x100f_97fc, 2); goto l_0x100f_97fc; /* jmp 0x100f97fc */
        l_0x100f_97fa:
            ii(0x100f_97fa, 2); jmp(0x100f_97fe, 2); goto l_0x100f_97fe; /* jmp 0x100f97fe */
        l_0x100f_97fc:
            ii(0x100f_97fc, 2); jmp(0x100f_97ad, -0x51); goto l_0x100f_97ad; /* jmp 0x100f97ad */
        l_0x100f_97fe:
            ii(0x100f_97fe, 4); cmp(memb[ss, ebp - 4], 2);              /* cmp byte [ebp-0x4], 0x2 */
            ii(0x100f_9802, 2); if(jnz(0x100f_9808, 4)) goto l_0x100f_9808; /* jnz 0x100f9808 */
            ii(0x100f_9804, 4); mov(memb[ss, ebp - 4], 0x26);           /* mov byte [ebp-0x4], 0x26 */
        l_0x100f_9808:
            ii(0x100f_9808, 7); cmp(memb[ds, 0x101c_391e], 7);          /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_980f, 2); if(jnz(0x100f_9817, 6)) goto l_0x100f_9817; /* jnz 0x100f9817 */
            ii(0x100f_9811, 4); cmp(memb[ss, ebp - 4], 0x26);           /* cmp byte [ebp-0x4], 0x26 */
            ii(0x100f_9815, 2); if(jnz(0x100f_9819, 2)) goto l_0x100f_9819; /* jnz 0x100f9819 */
        l_0x100f_9817:
            ii(0x100f_9817, 2); jmp(0x100f_981d, 4); goto l_0x100f_981d; /* jmp 0x100f981d */
        l_0x100f_9819:
            ii(0x100f_9819, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
        l_0x100f_981d:
            ii(0x100f_981d, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x100f_9821, 5); call(0x1012_1216, 0x2_79f0);            /* call 0x10121216 */
            ii(0x100f_9826, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100f_9829, 4); cmp(memb[ss, ebp - 4], 0x26);           /* cmp byte [ebp-0x4], 0x26 */
            ii(0x100f_982d, 2); if(jnz(0x100f_988d, 0x5e)) goto l_0x100f_988d; /* jnz 0x100f988d */
            ii(0x100f_982f, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_9834, 5); call(0x100e_883d, -0x1_0ffc);           /* call 0x100e883d */
            ii(0x100f_9839, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_983c, 5); mov(eax, memd[ds, 0x101c_38cc]);        /* mov eax, [0x101c38cc] */
            ii(0x100f_9841, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x100f_9844, 2); sub(eax, memd[ds, edx]);                /* sub eax, [edx] */
            ii(0x100f_9846, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_984d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9850, 6); add(eax, memd[ds, 0x101c_38ec]);        /* add eax, [0x101c38ec] */
            ii(0x100f_9856, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x100f_9859, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100f_985c, 5); mov(eax, memd[ds, 0x101c_38d0]);        /* mov eax, [0x101c38d0] */
            ii(0x100f_9861, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x100f_9864, 3); sub(eax, memd[ds, edx + 4]);            /* sub eax, [edx+0x4] */
            ii(0x100f_9867, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_986e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9871, 6); add(eax, memd[ds, 0x101c_38f0]);        /* add eax, [0x101c38f0] */
            ii(0x100f_9877, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x100f_987a, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100f_987d, 4); movsx(edx, memw[ss, ebp - 52]);         /* movsx edx, word [ebp-0x34] */
            ii(0x100f_9881, 4); movsx(eax, memw[ss, ebp - 48]);         /* movsx eax, word [ebp-0x30] */
            ii(0x100f_9885, 5); call(0x100f_7fb2, -0x18d8);             /* call 0x100f7fb2 */
            ii(0x100f_988a, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
        l_0x100f_988d:
            ii(0x100f_988d, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x100f_9891, 5); call(0x1012_0d94, 0x2_74fe);            /* call 0x10120d94 */
            ii(0x100f_9896, 7); test(memb[ds, 0x101c_38d4], 3);         /* test byte [0x101c38d4], 0x3 */
            ii(0x100f_989d, 6); if(jz(0x100f_9950, 0xad)) goto l_0x100f_9950; /* jz 0x100f9950 */
            ii(0x100f_98a3, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100f_98a6, 5); mov(memb[ds, 0x101c_38d8], al);         /* mov [0x101c38d8], al */
            ii(0x100f_98ab, 4); cmp(memb[ss, ebp - 4], 0x26);           /* cmp byte [ebp-0x4], 0x26 */
            ii(0x100f_98af, 6); if(jnz(0x100f_9950, 0x9b)) goto l_0x100f_9950; /* jnz 0x100f9950 */
            ii(0x100f_98b5, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_98ba, 5); call(0x100e_883d, -0x1_1082);           /* call 0x100e883d */
            ii(0x100f_98bf, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_98c2, 6); mov(ax, memw[ds, 0x101c_38cc]);         /* mov ax, [0x101c38cc] */
            ii(0x100f_98c8, 6); mov(memw[ds, 0x101c_389a], ax);         /* mov [0x101c389a], ax */
            ii(0x100f_98ce, 6); mov(ax, memw[ds, 0x101c_38d0]);         /* mov ax, [0x101c38d0] */
            ii(0x100f_98d4, 6); mov(memw[ds, 0x101c_389c], ax);         /* mov [0x101c389c], ax */
            ii(0x100f_98da, 5); mov(eax, memd[ds, 0x101c_38cc]);        /* mov eax, [0x101c38cc] */
            ii(0x100f_98df, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x100f_98e2, 2); sub(eax, memd[ds, edx]);                /* sub eax, [edx] */
            ii(0x100f_98e4, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_98eb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_98ee, 6); add(eax, memd[ds, 0x101c_38ec]);        /* add eax, [0x101c38ec] */
            ii(0x100f_98f4, 6); mov(memw[ds, 0x101c_389e], ax);         /* mov [0x101c389e], ax */
            ii(0x100f_98fa, 5); mov(eax, memd[ds, 0x101c_38d0]);        /* mov eax, [0x101c38d0] */
            ii(0x100f_98ff, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x100f_9902, 3); sub(eax, memd[ds, edx + 4]);            /* sub eax, [edx+0x4] */
            ii(0x100f_9905, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_990c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_990f, 6); add(eax, memd[ds, 0x101c_38f0]);        /* add eax, [0x101c38f0] */
            ii(0x100f_9915, 6); mov(memw[ds, 0x101c_38a0], ax);         /* mov [0x101c38a0], ax */
            ii(0x100f_991b, 5); mov(eax, memd[ds, 0x101c_389c]);        /* mov eax, [0x101c389c] */
            ii(0x100f_9920, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9923, 5); mov(memd[ds, 0x101c_38ac], eax);        /* mov [0x101c38ac], eax */
            ii(0x100f_9928, 5); mov(eax, memd[ds, 0x101c_38ac]);        /* mov eax, [0x101c38ac] */
            ii(0x100f_992d, 5); mov(memd[ds, 0x101c_38a4], eax);        /* mov [0x101c38a4], eax */
            ii(0x100f_9932, 5); mov(eax, memd[ds, 0x101c_389e]);        /* mov eax, [0x101c389e] */
            ii(0x100f_9937, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_993a, 5); mov(memd[ds, 0x101c_38b0], eax);        /* mov [0x101c38b0], eax */
            ii(0x100f_993f, 5); mov(eax, memd[ds, 0x101c_38b0]);        /* mov eax, [0x101c38b0] */
            ii(0x100f_9944, 5); mov(memd[ds, 0x101c_38a8], eax);        /* mov [0x101c38a8], eax */
            ii(0x100f_9949, 7); mov(memb[ds, 0x101c_38a2], 1);          /* mov byte [0x101c38a2], 0x1 */
        l_0x100f_9950:
            ii(0x100f_9950, 7); cmp(memd[ds, 0x101c_38d4], 0);          /* cmp dword [0x101c38d4], 0x0 */
            ii(0x100f_9957, 2); if(jnz(0x100f_9962, 9)) goto l_0x100f_9962; /* jnz 0x100f9962 */
            ii(0x100f_9959, 5); call(/* sys */ 0x1016_c348, 0x7_29ea);  /* call 0x1016c348 */
            ii(0x100f_995e, 2); test(al, 4);                            /* test al, 0x4 */
            ii(0x100f_9960, 2); if(jnz(0x100f_9964, 2)) goto l_0x100f_9964; /* jnz 0x100f9964 */
        l_0x100f_9962:
            ii(0x100f_9962, 2); jmp(0x100f_996b, 7); goto l_0x100f_996b; /* jmp 0x100f996b */
        l_0x100f_9964:
            ii(0x100f_9964, 7); or(memb[ds, 0x101c_38d4], 1);           /* or byte [0x101c38d4], 0x1 */
        l_0x100f_996b:
            ii(0x100f_996b, 7); cmp(memd[ds, 0x101c_38d4], 0);          /* cmp dword [0x101c38d4], 0x0 */
            ii(0x100f_9972, 6); if(jz(0x100f_99cf, 0x57)) goto l_0x100f_99cf; /* jz 0x100f99cf */
            ii(0x100f_9978, 5); mov(al, memb[ds, 0x101c_38d8]);         /* mov al, [0x101c38d8] */
            ii(0x100f_997d, 3); cmp(al, memb[ss, ebp - 4]);             /* cmp al, [ebp-0x4] */
            ii(0x100f_9980, 2); if(jz(0x100f_99cf, 0x4d)) goto l_0x100f_99cf; /* jz 0x100f99cf */
            ii(0x100f_9982, 7); cmp(memb[ds, 0x101c_38d8], 0x23);       /* cmp byte [0x101c38d8], 0x23 */
            ii(0x100f_9989, 2); if(jnz(0x100f_9991, 6)) goto l_0x100f_9991; /* jnz 0x100f9991 */
            ii(0x100f_998b, 4); mov(memb[ss, ebp - 4], 0x23);           /* mov byte [ebp-0x4], 0x23 */
            ii(0x100f_998f, 2); jmp(0x100f_99cf, 0x3e); goto l_0x100f_99cf; /* jmp 0x100f99cf */
        l_0x100f_9991:
            ii(0x100f_9991, 7); cmp(memb[ds, 0x101c_38d8], 0x27);       /* cmp byte [0x101c38d8], 0x27 */
            ii(0x100f_9998, 2); if(jl(0x100f_99a3, 9)) goto l_0x100f_99a3; /* jl 0x100f99a3 */
            ii(0x100f_999a, 7); cmp(memb[ds, 0x101c_38d8], 0x32);       /* cmp byte [0x101c38d8], 0x32 */
            ii(0x100f_99a1, 2); if(jle(0x100f_99a5, 2)) goto l_0x100f_99a5; /* jle 0x100f99a5 */
        l_0x100f_99a3:
            ii(0x100f_99a3, 2); jmp(0x100f_99ab, 6); goto l_0x100f_99ab; /* jmp 0x100f99ab */
        l_0x100f_99a5:
            ii(0x100f_99a5, 4); cmp(memb[ss, ebp - 4], 0x27);           /* cmp byte [ebp-0x4], 0x27 */
            ii(0x100f_99a9, 2); if(jge(0x100f_99ad, 2)) goto l_0x100f_99ad; /* jge 0x100f99ad */
        l_0x100f_99ab:
            ii(0x100f_99ab, 2); jmp(0x100f_99b3, 6); goto l_0x100f_99b3; /* jmp 0x100f99b3 */
        l_0x100f_99ad:
            ii(0x100f_99ad, 4); cmp(memb[ss, ebp - 4], 0x32);           /* cmp byte [ebp-0x4], 0x32 */
            ii(0x100f_99b1, 2); if(jle(0x100f_99cf, 0x1c)) goto l_0x100f_99cf; /* jle 0x100f99cf */
        l_0x100f_99b3:
            ii(0x100f_99b3, 7); cmp(memb[ds, 0x101c_38a2], 0);          /* cmp byte [0x101c38a2], 0x0 */
            ii(0x100f_99ba, 2); if(jz(0x100f_99c5, 9)) goto l_0x100f_99c5; /* jz 0x100f99c5 */
            ii(0x100f_99bc, 7); test(memb[ds, 0x101c_38d4], 3);         /* test byte [0x101c38d4], 0x3 */
            ii(0x100f_99c3, 2); if(jz(0x100f_99cf, 0xa)) goto l_0x100f_99cf; /* jz 0x100f99cf */
        l_0x100f_99c5:
            ii(0x100f_99c5, 10); mov(memd[ds, 0x101c_38d4], 0);         /* mov dword [0x101c38d4], 0x0 */
        l_0x100f_99cf:
            ii(0x100f_99cf, 7); test(memb[ds, 0x101c_38d4], 0x30);      /* test byte [0x101c38d4], 0x30 */
            ii(0x100f_99d6, 2); if(jz(0x100f_9a18, 0x40)) goto l_0x100f_9a18; /* jz 0x100f9a18 */
            ii(0x100f_99d8, 7); mov(memb[ds, 0x101c_38d8], 0);          /* mov byte [0x101c38d8], 0x0 */
            ii(0x100f_99df, 7); cmp(memb[ds, 0x101c_38a2], 0);          /* cmp byte [0x101c38a2], 0x0 */
            ii(0x100f_99e6, 2); if(jz(0x100f_9a18, 0x30)) goto l_0x100f_9a18; /* jz 0x100f9a18 */
            ii(0x100f_99e8, 7); cmp(memb[ds, 0x101c_38a2], 2);          /* cmp byte [0x101c38a2], 0x2 */
            ii(0x100f_99ef, 2); if(jnz(0x100f_9a0a, 0x19)) goto l_0x100f_9a0a; /* jnz 0x100f9a0a */
            ii(0x100f_99f1, 5); mov(edx, 0x101c_38a4);                  /* mov edx, 0x101c38a4 */
            ii(0x100f_99f6, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_99fb, 5); call(0x1007_6600, -0x8_3400);           /* call 0x10076600 */
            ii(0x100f_9a00, 5); call(0x1007_5537, -0x8_44ce);           /* call 0x10075537 */
            ii(0x100f_9a05, 5); call(0x100f_f5c1, 0x5bb7);              /* call 0x100ff5c1 */
        l_0x100f_9a0a:
            ii(0x100f_9a0a, 7); mov(memb[ds, 0x101c_38a2], 0);          /* mov byte [0x101c38a2], 0x0 */
            ii(0x100f_9a11, 7); mov(memb[ds, 0x101c_38a3], 0);          /* mov byte [0x101c38a3], 0x0 */
        l_0x100f_9a18:
            ii(0x100f_9a18, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100f_9a1b, 3); mov(memb[ss, ebp - 56], al);            /* mov [ebp-0x38], al */
            ii(0x100f_9a1e, 5); jmp(0x100f_9ae4, 0xc1); goto l_0x100f_9ae4; /* jmp 0x100f9ae4 */
        l_0x100f_9a23:
            ii(0x100f_9a23, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x100f_9a28, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9a2a, 5); call(0x100f_95e0, -0x44f);              /* call 0x100f95e0 */
            ii(0x100f_9a2f, 5); jmp(0x100f_9b01, 0xcd); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        l_0x100f_9a34:
            ii(0x100f_9a34, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x100f_9a39, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100f_9a3e, 5); call(0x100f_95e0, -0x463);              /* call 0x100f95e0 */
            ii(0x100f_9a43, 5); jmp(0x100f_9b01, 0xb9); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        l_0x100f_9a48:
            ii(0x100f_9a48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9a4a, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100f_9a4f, 5); call(0x100f_95e0, -0x474);              /* call 0x100f95e0 */
            ii(0x100f_9a54, 5); jmp(0x100f_9b01, 0xa8); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        l_0x100f_9a59:
            ii(0x100f_9a59, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_9a5e, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100f_9a63, 5); call(0x100f_95e0, -0x488);              /* call 0x100f95e0 */
            ii(0x100f_9a68, 5); jmp(0x100f_9b01, 0x94); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        l_0x100f_9a6d:
            ii(0x100f_9a6d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_9a72, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9a74, 5); call(0x100f_95e0, -0x499);              /* call 0x100f95e0 */
            ii(0x100f_9a79, 5); jmp(0x100f_9b01, 0x83); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        l_0x100f_9a7e:
            ii(0x100f_9a7e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_9a83, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x100f_9a88, 5); call(0x100f_95e0, -0x4ad);              /* call 0x100f95e0 */
            ii(0x100f_9a8d, 5); jmp(0x100f_9b01, 0x6f); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        l_0x100f_9a92:
            ii(0x100f_9a92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9a94, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x100f_9a99, 5); call(0x100f_95e0, -0x4be);              /* call 0x100f95e0 */
            ii(0x100f_9a9e, 2); jmp(0x100f_9b01, 0x61); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        l_0x100f_9aa0:
            ii(0x100f_9aa0, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x100f_9aa5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x100f_9aaa, 5); call(0x100f_95e0, -0x4cf);              /* call 0x100f95e0 */
            ii(0x100f_9aaf, 2); jmp(0x100f_9b01, 0x50); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        l_0x100f_9ab1:
            ii(0x100f_9ab1, 2); jmp(0x100f_9b01, 0x4e); goto l_0x100f_9b01; /* jmp 0x100f9b01 */
        //  ii(0x100f_9ab3, 1); nop();                                  /* nop */
        //  ii(0x100f_9ab4, 48); /* Служебная область с абсолютными адресами переходов. (0x100f_9a23, 0x100f_9a34, 0x100f_9a34, 0x100f_9a48, 0x100f_9a59, 0x100f_9a59, 0x100f_9a6d, 0x100f_9a7e, 0x100f_9a7e, 0x100f_9a92, 0x100f_9aa0, 0x100f_9aa0). */
        l_0x100f_9ae4:
            ii(0x100f_9ae4, 3); mov(al, memb[ss, ebp - 56]);            /* mov al, [ebp-0x38] */
            ii(0x100f_9ae7, 2); sub(al, 0x27);                          /* sub al, 0x27 */
            ii(0x100f_9ae9, 3); mov(memb[ss, ebp - 60], al);            /* mov [ebp-0x3c], al */
            ii(0x100f_9aec, 4); cmp(memb[ss, ebp - 60], 0xb);           /* cmp byte [ebp-0x3c], 0xb */
            ii(0x100f_9af0, 2); if(ja(0x100f_9ab1, -0x41)) goto l_0x100f_9ab1; /* ja 0x100f9ab1 */
            ii(0x100f_9af2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9af4, 3); mov(al, memb[ss, ebp - 60]);            /* mov al, [ebp-0x3c] */
            ii(0x100f_9af7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100f_9afa, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x100f_9ab4]))
            {
                case 0x100f_9a23:
                    goto l_0x100f_9a23;
                case 0x100f_9a34:
                    goto l_0x100f_9a34;
                case 0x100f_9a48:
                    goto l_0x100f_9a48;
                case 0x100f_9a59:
                    goto l_0x100f_9a59;
                case 0x100f_9a6d:
                    goto l_0x100f_9a6d;
                case 0x100f_9a7e:
                    goto l_0x100f_9a7e;
                case 0x100f_9a92:
                    goto l_0x100f_9a92;
                case 0x100f_9aa0:
                    goto l_0x100f_9aa0;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x100f9ab4] */
        l_0x100f_9b01:
            ii(0x100f_9b01, 4); cmp(memb[ss, ebp - 4], 0x26);           /* cmp byte [ebp-0x4], 0x26 */
            ii(0x100f_9b05, 2); if(jnz(0x100f_9b27, 0x20)) goto l_0x100f_9b27; /* jnz 0x100f9b27 */
            ii(0x100f_9b07, 6); mov(ax, memw[ds, 0x101c_3908]);         /* mov ax, [0x101c3908] */
            ii(0x100f_9b0d, 7); cmp(ax, memw[ds, 0x101c_390c]);         /* cmp ax, [0x101c390c] */
            ii(0x100f_9b14, 2); if(jnz(0x100f_9b25, 0xf)) goto l_0x100f_9b25; /* jnz 0x100f9b25 */
            ii(0x100f_9b16, 6); mov(ax, memw[ds, 0x101c_390a]);         /* mov ax, [0x101c390a] */
            ii(0x100f_9b1c, 7); cmp(ax, memw[ds, 0x101c_390e]);         /* cmp ax, [0x101c390e] */
            ii(0x100f_9b23, 2); if(jz(0x100f_9b27, 2)) goto l_0x100f_9b27; /* jz 0x100f9b27 */
        l_0x100f_9b25:
            ii(0x100f_9b25, 2); jmp(0x100f_9b29, 2); goto l_0x100f_9b29; /* jmp 0x100f9b29 */
        l_0x100f_9b27:
            ii(0x100f_9b27, 2); jmp(0x100f_9b82, 0x59); goto l_0x100f_9b82; /* jmp 0x100f9b82 */
        l_0x100f_9b29:
            ii(0x100f_9b29, 6); mov(ax, memw[ds, 0x101c_390a]);         /* mov ax, [0x101c390a] */
            ii(0x100f_9b2f, 1); inc(eax);                               /* inc eax */
            ii(0x100f_9b30, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_9b33, 6); mov(ax, memw[ds, 0x101c_3908]);         /* mov ax, [0x101c3908] */
            ii(0x100f_9b39, 1); inc(eax);                               /* inc eax */
            ii(0x100f_9b3a, 1); cwde();                                 /* cwde */
            ii(0x100f_9b3b, 5); call(0x100f_32a2, -0x689e);             /* call 0x100f32a2 */
            ii(0x100f_9b40, 7); cmp(memb[ds, 0x101c_37d4], 0);          /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_9b47, 2); if(jz(0x100f_9b6a, 0x21)) goto l_0x100f_9b6a; /* jz 0x100f9b6a */
            ii(0x100f_9b49, 6); mov(ebx, memd[ds, 0x101c_3908]);        /* mov ebx, [0x101c3908] */
            ii(0x100f_9b4f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9b52, 6); mov(edx, memd[ds, 0x101c_3906]);        /* mov edx, [0x101c3906] */
            ii(0x100f_9b58, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_9b5b, 5); mov(eax, 0x101c_37c4);                  /* mov eax, 0x101c37c4 */
            ii(0x100f_9b60, 5); call(0x1008_abbc, -0x6_efa9);           /* call 0x1008abbc */
            ii(0x100f_9b65, 5); call(0x1016_309a, 0x6_9530);            /* call 0x1016309a */
        l_0x100f_9b6a:
            ii(0x100f_9b6a, 6); mov(ax, memw[ds, 0x101c_3908]);         /* mov ax, [0x101c3908] */
            ii(0x100f_9b70, 6); mov(memw[ds, 0x101c_390c], ax);         /* mov [0x101c390c], ax */
            ii(0x100f_9b76, 6); mov(ax, memw[ds, 0x101c_390a]);         /* mov ax, [0x101c390a] */
            ii(0x100f_9b7c, 6); mov(memw[ds, 0x101c_390e], ax);         /* mov [0x101c390e], ax */
        l_0x100f_9b82:
            ii(0x100f_9b82, 7); cmp(memd[ds, 0x101c_38d4], 0);          /* cmp dword [0x101c38d4], 0x0 */
            ii(0x100f_9b89, 6); if(jz_func(0x100f_a7df, 0xc50)) return; /* jz 0x100fa7df */
            ii(0x100f_9b8f, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x100f_9b93, 5); call(0x100e_883d, -0x1_135b);           /* call 0x100e883d */
            ii(0x100f_9b98, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_9b9b, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100f_9b9e, 3); mov(memb[ss, ebp - 64], al);            /* mov [ebp-0x40], al */
            ii(0x100f_9ba1, 5); if(jmp_func(0x100f_a76e, 0xbc8)) return; /* jmp 0x100fa76e */
        }
    }
}
