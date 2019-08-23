using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_8266-16cee1a7")]
        public void Method_1007_8266()
        {
            ii(0x1007_8266, 5); push(0x80);                             /* push 0x80 */
            ii(0x1007_826b, 5); call(Definitions.sys_check_available_stack_size, 0xe_dae2); /* call 0x10165d52 */
            ii(0x1007_8270, 1); push(esi);                              /* push esi */
            ii(0x1007_8271, 1); push(edi);                              /* push edi */
            ii(0x1007_8272, 1); push(ebp);                              /* push ebp */
            ii(0x1007_8273, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_8275, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x1007_827b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_827e, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1007_8281, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_8284, 3); mov(memb[ss, ebp - 0x4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1007_8287, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_828a, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_828d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8292, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_8298, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1007_829d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_829f, 5); call(0x100b_a098, 0x4_1df4);            /* call 0x100ba098 */
            ii(0x1007_82a4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_82a6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_82a9, 5); call(0x1008_a1a4, 0x1_1ef6);            /* call 0x1008a1a4 */
            ii(0x1007_82ae, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_82b5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_82b8, 5); call(0x1007_623c, -0x2081);             /* call 0x1007623c */
            ii(0x1007_82bd, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_82c0, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_82c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_82c9, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_82cc, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1007_82cf, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_82d2, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_82d9, 7); mov(memd[ss, ebp - 0x2c], 0x7d00);      /* mov dword [ebp-0x2c], 0x7d00 */
            ii(0x1007_82e0, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_82e3, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x1007_82e7, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_82ea, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_82ed, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x1007_82f1, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1007_82f4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_82f7, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1007_82fa, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_82fd, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x1007_8300, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_8302, 6); mov(al, memb[ds, edx + 0x101c_81d4]);   /* mov al, [edx+0x101c81d4] */
            ii(0x1007_8308, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1007_830b, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_830e, 5); call(Definitions.my_ctor_0x101b_4184, -0x1823); /* call 0x10076af0 */
            ii(0x1007_8313, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1007_8316, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_831a, 5); call(0x1007_8137, -0x1e8);              /* call 0x10078137 */
            ii(0x1007_831f, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1007_8323, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1007_8327, 5); call(Definitions.my_min, 0x1_1458);     /* call 0x10089784 */
            ii(0x1007_832c, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_832f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_8332, 4); imul(eax, memd[ss, ebp - 0x30]);        /* imul eax, [ebp-0x30] */
            ii(0x1007_8336, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_8339, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1007_833c, 4); imul(eax, memd[ss, ebp - 0x34]);        /* imul eax, [ebp-0x34] */
            ii(0x1007_8340, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1007_8343, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_8346, 4); imul(eax, memd[ss, ebp - 0xc]);         /* imul eax, [ebp-0xc] */
            ii(0x1007_834a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_834d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8350, 4); imul(eax, memd[ss, ebp - 0x8]);         /* imul eax, [ebp-0x8] */
            ii(0x1007_8354, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_8357, 2); jmp(0x1007_8361, 0x8); goto l_0x1007_8361; /* jmp 0x10078361 */
        l_0x1007_8359:
            ii(0x1007_8359, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_835c, 5); call(0x1007_6bf8, -0x1769);             /* call 0x10076bf8 */
        l_0x1007_8361:
            ii(0x1007_8361, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8363, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_8366, 5); call(0x1013_ad71, 0xc_2a06);            /* call 0x1013ad71 */
            ii(0x1007_836b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_836d, 6); if(jz(0x1007_8762, 0x3ef)) goto l_0x1007_8762; /* jz 0x10078762 */
            ii(0x1007_8373, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_8376, 5); call(0x1008_a0f8, 0x1_1d7d);            /* call 0x1008a0f8 */
            ii(0x1007_837b, 5); call(0x1008_a370, 0x1_1ff0);            /* call 0x1008a370 */
            ii(0x1007_8380, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1007_8383, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_8386, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_8389, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_838e, 5); cmp(memb[ds, eax + ebp - 0x44], 0);     /* cmp byte [eax+ebp-0x44], 0x0 */
            ii(0x1007_8393, 6); if(jz(0x1007_875d, 0x3c4)) goto l_0x1007_875d; /* jz 0x1007875d */
            ii(0x1007_8399, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_839c, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_83a0, 2); if(jz(0x1007_83ab, 0x9)) goto l_0x1007_83ab; /* jz 0x100783ab */
            ii(0x1007_83a2, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_83a5, 4); cmp(memb[ds, eax + 0x3e], 0xe);         /* cmp byte [eax+0x3e], 0xe */
            ii(0x1007_83a9, 2); if(jnz(0x1007_83ad, 0x2)) goto l_0x1007_83ad; /* jnz 0x100783ad */
        l_0x1007_83ab:
            ii(0x1007_83ab, 2); jmp(0x1007_83bc, 0xf); goto l_0x1007_83bc; /* jmp 0x100783bc */
        l_0x1007_83ad:
            ii(0x1007_83ad, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_83b0, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_83b3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_83b8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_83ba, 2); if(jg(0x1007_83be, 0x2)) goto l_0x1007_83be; /* jg 0x100783be */
        l_0x1007_83bc:
            ii(0x1007_83bc, 2); jmp(0x1007_83c7, 0x9); goto l_0x1007_83c7; /* jmp 0x100783c7 */
        l_0x1007_83be:
            ii(0x1007_83be, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_83c1, 4); cmp(memb[ds, eax + 0x3d], 0x9);         /* cmp byte [eax+0x3d], 0x9 */
            ii(0x1007_83c5, 2); if(jnz(0x1007_83cc, 0x5)) goto l_0x1007_83cc; /* jnz 0x100783cc */
        l_0x1007_83c7:
            ii(0x1007_83c7, 5); jmp(0x1007_875d, 0x391); goto l_0x1007_875d; /* jmp 0x1007875d */
        l_0x1007_83cc:
            ii(0x1007_83cc, 3); lea(edx, ebp - 0x4c);                   /* lea edx, [ebp-0x4c] */
            ii(0x1007_83cf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_83d2, 5); call(0x1008_a0f8, 0x1_1d21);            /* call 0x1008a0f8 */
            ii(0x1007_83d7, 5); call(0x100b_8e63, 0x4_0a87);            /* call 0x100b8e63 */
            ii(0x1007_83dc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_83de, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_83e1, 5); call(0x1008_8b44, 0x1_075e);            /* call 0x10088b44 */
            ii(0x1007_83e6, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x1007_83e9, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1007_83ec, 5); call(0x1007_5e64, -0x258d);             /* call 0x10075e64 */
            ii(0x1007_83f1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_83f3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_83f6, 5); call(0x1007_0ca1, -0x775a);             /* call 0x10070ca1 */
            ii(0x1007_83fb, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1007_83fe, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1007_8401, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1007_8405, 6); if(jg(0x1007_875d, 0x352)) goto l_0x1007_875d; /* jg 0x1007875d */
            ii(0x1007_840b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_840e, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_8411, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_8413, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_8416, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_8419, 5); call(0x1007_6074, -0x23aa);             /* call 0x10076074 */
            ii(0x1007_841e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8420, 2); if(jnz(0x1007_842b, 0x9)) goto l_0x1007_842b; /* jnz 0x1007842b */
            ii(0x1007_8422, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1007_8425, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1007_8429, 2); if(jg(0x1007_842d, 0x2)) goto l_0x1007_842d; /* jg 0x1007842d */
        l_0x1007_842b:
            ii(0x1007_842b, 2); jmp(0x1007_8432, 0x5); goto l_0x1007_8432; /* jmp 0x10078432 */
        l_0x1007_842d:
            ii(0x1007_842d, 5); jmp(0x1007_875d, 0x32b); goto l_0x1007_875d; /* jmp 0x1007875d */
        l_0x1007_8432:
            ii(0x1007_8432, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_8435, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_843a, 2); if(jnz(0x1007_8453, 0x17)) goto l_0x1007_8453; /* jnz 0x10078453 */
            ii(0x1007_843c, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_843f, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_8442, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_8444, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_8447, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_844a, 5); call(0x1007_6074, -0x23db);             /* call 0x10076074 */
            ii(0x1007_844f, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8451, 2); if(jz(0x1007_8455, 0x2)) goto l_0x1007_8455; /* jz 0x10078455 */
        l_0x1007_8453:
            ii(0x1007_8453, 2); jmp(0x1007_8484, 0x2f); goto l_0x1007_8484; /* jmp 0x10078484 */
        l_0x1007_8455:
            ii(0x1007_8455, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1007_8458, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_845b, 5); call(0x1007_78a5, -0xbbb);              /* call 0x100778a5 */
            ii(0x1007_8460, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8462, 6); if(jz(0x1007_875d, 0x2f5)) goto l_0x1007_875d; /* jz 0x1007875d */
            ii(0x1007_8468, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1007_846d, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1007_8470, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_8473, 5); call(0x1015_c75a, 0xe_42e2);            /* call 0x1015c75a */
            ii(0x1007_8478, 1); cwde();                                 /* cwde */
            ii(0x1007_8479, 3); cmp(eax, 0x55);                         /* cmp eax, 0x55 */
            ii(0x1007_847c, 6); if(jle(0x1007_875d, 0x2db)) goto l_0x1007_875d; /* jle 0x1007875d */
            ii(0x1007_8482, 2); jmp(0x1007_8497, 0x13); goto l_0x1007_8497; /* jmp 0x10078497 */
        l_0x1007_8484:
            ii(0x1007_8484, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1007_8487, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_848a, 5); call(0x1007_4bde, -0x38b1);             /* call 0x10074bde */
            ii(0x1007_848f, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8491, 6); if(jz(0x1007_875d, 0x2c6)) goto l_0x1007_875d; /* jz 0x1007875d */
        l_0x1007_8497:
            ii(0x1007_8497, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1007_849b, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_849e, 5); call(0x1007_6074, -0x242f);             /* call 0x10076074 */
            ii(0x1007_84a3, 2); test(al, al);                           /* test al, al */
            ii(0x1007_84a5, 2); if(jnz(0x1007_84eb, 0x44)) goto l_0x1007_84eb; /* jnz 0x100784eb */
            ii(0x1007_84a7, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_84aa, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_84af, 2); if(jnz(0x1007_84bb, 0xa)) goto l_0x1007_84bb; /* jnz 0x100784bb */
            ii(0x1007_84b1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_84b4, 5); cmp(memw[ds, eax + 0x8], 0x43);         /* cmp word [eax+0x8], 0x43 */
            ii(0x1007_84b9, 2); if(jnz(0x1007_84bd, 0x2)) goto l_0x1007_84bd; /* jnz 0x100784bd */
        l_0x1007_84bb:
            ii(0x1007_84bb, 2); jmp(0x1007_84c7, 0xa); goto l_0x1007_84c7; /* jmp 0x100784c7 */
        l_0x1007_84bd:
            ii(0x1007_84bd, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_84c0, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_84c5, 2); if(jnz(0x1007_84c9, 0x2)) goto l_0x1007_84c9; /* jnz 0x100784c9 */
        l_0x1007_84c7:
            ii(0x1007_84c7, 2); jmp(0x1007_84ce, 0x5); goto l_0x1007_84ce; /* jmp 0x100784ce */
        l_0x1007_84c9:
            ii(0x1007_84c9, 5); jmp(0x1007_875d, 0x28f); goto l_0x1007_875d; /* jmp 0x1007875d */
        l_0x1007_84ce:
            ii(0x1007_84ce, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_84d1, 5); call(0x1016_433b, 0xe_be65);            /* call 0x1016433b */
            ii(0x1007_84d6, 2); test(al, al);                           /* test al, al */
            ii(0x1007_84d8, 2); if(jz(0x1007_84e4, 0xa)) goto l_0x1007_84e4; /* jz 0x100784e4 */
            ii(0x1007_84da, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_84dd, 5); cmp(memw[ds, eax + 0x8], 0x45);         /* cmp word [eax+0x8], 0x45 */
            ii(0x1007_84e2, 2); if(jnz(0x1007_84e6, 0x2)) goto l_0x1007_84e6; /* jnz 0x100784e6 */
        l_0x1007_84e4:
            ii(0x1007_84e4, 2); jmp(0x1007_84eb, 0x5); goto l_0x1007_84eb; /* jmp 0x100784eb */
        l_0x1007_84e6:
            ii(0x1007_84e6, 5); jmp(0x1007_875d, 0x272); goto l_0x1007_875d; /* jmp 0x1007875d */
        l_0x1007_84eb:
            ii(0x1007_84eb, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_84ee, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_84f2, 2); if(jnz(0x1007_84fd, 0x9)) goto l_0x1007_84fd; /* jnz 0x100784fd */
            ii(0x1007_84f4, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_84f7, 4); test(memb[ds, eax + 0x13], 0x2);        /* test byte [eax+0x13], 0x2 */
            ii(0x1007_84fb, 2); if(jz(0x1007_84ff, 0x2)) goto l_0x1007_84ff; /* jz 0x100784ff */
        l_0x1007_84fd:
            ii(0x1007_84fd, 2); jmp(0x1007_8509, 0xa); goto l_0x1007_8509; /* jmp 0x10078509 */
        l_0x1007_84ff:
            ii(0x1007_84ff, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_8502, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_8507, 2); if(jnz(0x1007_850b, 0x2)) goto l_0x1007_850b; /* jnz 0x1007850b */
        l_0x1007_8509:
            ii(0x1007_8509, 2); jmp(0x1007_851a, 0xf); goto l_0x1007_851a; /* jmp 0x1007851a */
        l_0x1007_850b:
            ii(0x1007_850b, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_8510, 5); call(0x1007_5fdc, -0x2539);             /* call 0x10075fdc */
            ii(0x1007_8515, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1007_8518, 2); if(jge(0x1007_851c, 0x2)) goto l_0x1007_851c; /* jge 0x1007851c */
        l_0x1007_851a:
            ii(0x1007_851a, 2); jmp(0x1007_8521, 0x5); goto l_0x1007_8521; /* jmp 0x10078521 */
        l_0x1007_851c:
            ii(0x1007_851c, 5); jmp(0x1007_875d, 0x23c); goto l_0x1007_875d; /* jmp 0x1007875d */
        l_0x1007_8521:
            ii(0x1007_8521, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1007_8525, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_8528, 5); call(0x1007_6074, -0x24b9);             /* call 0x10076074 */
            ii(0x1007_852d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_852f, 2); if(jnz(0x1007_8564, 0x33)) goto l_0x1007_8564; /* jnz 0x10078564 */
            ii(0x1007_8531, 4); movsx(eax, memw[ss, ebp - 0x3a]);       /* movsx eax, word [ebp-0x3a] */
            ii(0x1007_8535, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x1007_853b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_853e, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1007_8541, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x1007_8545, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_8547, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_854b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_8551, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x1007_8557, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_8559, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1007_855b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8560, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_8562, 2); if(jnz(0x1007_8566, 0x2)) goto l_0x1007_8566; /* jnz 0x10078566 */
        l_0x1007_8564:
            ii(0x1007_8564, 2); jmp(0x1007_858d, 0x27); goto l_0x1007_858d; /* jmp 0x1007858d */
        l_0x1007_8566:
            ii(0x1007_8566, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_8569, 5); call(0x1008_a0f8, 0x1_1b8a);            /* call 0x1008a0f8 */
            ii(0x1007_856e, 5); call(0x100b_8f13, 0x4_09a0);            /* call 0x100b8f13 */
            ii(0x1007_8573, 3); lea(edx, ebp - 0x58);                   /* lea edx, [ebp-0x58] */
            ii(0x1007_8576, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_8579, 5); call(0x1008_a0f8, 0x1_1b7a);            /* call 0x1008a0f8 */
            ii(0x1007_857e, 5); call(0x100b_8e63, 0x4_08e0);            /* call 0x100b8e63 */
            ii(0x1007_8583, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_8585, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1007_8588, 5); call(0x1008_8b44, 0x1_05b7);            /* call 0x10088b44 */
        l_0x1007_858d:
            ii(0x1007_858d, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_8590, 5); cmp(memw[ds, eax + 0x8], 0x29);         /* cmp word [eax+0x8], 0x29 */
            ii(0x1007_8595, 2); if(jz(0x1007_85a1, 0xa)) goto l_0x1007_85a1; /* jz 0x100785a1 */
            ii(0x1007_8597, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_859a, 5); cmp(memw[ds, eax + 0x8], 0x2a);         /* cmp word [eax+0x8], 0x2a */
            ii(0x1007_859f, 2); if(jnz(0x1007_85c3, 0x22)) goto l_0x1007_85c3; /* jnz 0x100785c3 */
        l_0x1007_85a1:
            ii(0x1007_85a1, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_85a4, 3); mov(eax, memd[ds, eax + 0x1b]);         /* mov eax, [eax+0x1b] */
            ii(0x1007_85a7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_85aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_85ac, 2); if(jnz(0x1007_85bc, 0xe)) goto l_0x1007_85bc; /* jnz 0x100785bc */
            ii(0x1007_85ae, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_85b1, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_85b4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_85b7, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1007_85ba, 2); if(jge(0x1007_85be, 0x2)) goto l_0x1007_85be; /* jge 0x100785be */
        l_0x1007_85bc:
            ii(0x1007_85bc, 2); jmp(0x1007_85c3, 0x5); goto l_0x1007_85c3; /* jmp 0x100785c3 */
        l_0x1007_85be:
            ii(0x1007_85be, 5); jmp(0x1007_875d, 0x19a); goto l_0x1007_875d; /* jmp 0x1007875d */
        l_0x1007_85c3:
            ii(0x1007_85c3, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1007_85c7, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_85ca, 5); call(0x1007_6074, -0x255b);             /* call 0x10076074 */
            ii(0x1007_85cf, 2); test(al, al);                           /* test al, al */
            ii(0x1007_85d1, 2); if(jnz(0x1007_85f4, 0x21)) goto l_0x1007_85f4; /* jnz 0x100785f4 */
            ii(0x1007_85d3, 4); movsx(ebx, memw[ss, ebp - 0x38]);       /* movsx ebx, word [ebp-0x38] */
            ii(0x1007_85d7, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x1007_85da, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1007_85dd, 5); call(0x1007_5e64, -0x277e);             /* call 0x10075e64 */
            ii(0x1007_85e2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_85e4, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x1007_85e9, 5); call(0x100c_90d6, 0x5_0ae8);            /* call 0x100c90d6 */
            ii(0x1007_85ee, 4); cmp(ax, memw[ss, ebp - 0x30]);          /* cmp ax, [ebp-0x30] */
            ii(0x1007_85f2, 2); if(jg(0x1007_85f6, 0x2)) goto l_0x1007_85f6; /* jg 0x100785f6 */
        l_0x1007_85f4:
            ii(0x1007_85f4, 2); jmp(0x1007_85fb, 0x5); goto l_0x1007_85fb; /* jmp 0x100785fb */
        l_0x1007_85f6:
            ii(0x1007_85f6, 5); jmp(0x1007_875d, 0x162); goto l_0x1007_875d; /* jmp 0x1007875d */
        l_0x1007_85fb:
            ii(0x1007_85fb, 4); movsx(ebx, memw[ss, ebp - 0x38]);       /* movsx ebx, word [ebp-0x38] */
            ii(0x1007_85ff, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x1007_8602, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x1007_8605, 5); call(0x1007_5e64, -0x27a6);             /* call 0x10075e64 */
            ii(0x1007_860a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_860c, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x1007_8611, 5); call(0x100c_90d6, 0x5_0ac0);            /* call 0x100c90d6 */
            ii(0x1007_8616, 4); cmp(ax, memw[ss, ebp - 0x34]);          /* cmp ax, [ebp-0x34] */
            ii(0x1007_861a, 6); if(jg(0x1007_875d, 0x13d)) goto l_0x1007_875d; /* jg 0x1007875d */
            ii(0x1007_8620, 4); cmp(memb[ss, ebp + 0x10], 0);           /* cmp byte [ebp+0x10], 0x0 */
            ii(0x1007_8624, 2); if(jnz(0x1007_862f, 0x9)) goto l_0x1007_862f; /* jnz 0x1007862f */
            ii(0x1007_8626, 7); mov(memd[ss, ebp - 0x64], 0);           /* mov dword [ebp-0x64], 0x0 */
            ii(0x1007_862d, 2); jmp(0x1007_8676, 0x47); goto l_0x1007_8676; /* jmp 0x10078676 */
        l_0x1007_862f:
            ii(0x1007_862f, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_8632, 5); call(0x1008_aa80, 0x1_2449);            /* call 0x1008aa80 */
            ii(0x1007_8637, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1007_863a, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1007_863d, 5); and(eax, 0xfe);                         /* and eax, 0xfe */
            ii(0x1007_8642, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x1007_8645, 4); movsx(eax, memw[ss, ebp - 0x64]);       /* movsx eax, word [ebp-0x64] */
            ii(0x1007_8649, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_864b, 2); if(jle(0x1007_8676, 0x29)) goto l_0x1007_8676; /* jle 0x10078676 */
            ii(0x1007_864d, 7); and(memd[ss, ebp - 0x68], 0xffff_ff01); /* and dword [ebp-0x68], 0xffffff01 */
            ii(0x1007_8654, 4); movsx(eax, memw[ss, ebp - 0x64]);       /* movsx eax, word [ebp-0x64] */
            ii(0x1007_8658, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_865b, 2); if(jle(0x1007_8667, 0xa)) goto l_0x1007_8667; /* jle 0x10078667 */
            ii(0x1007_865d, 4); movsx(eax, memw[ss, ebp - 0x64]);       /* movsx eax, word [ebp-0x64] */
            ii(0x1007_8661, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1007_8664, 3); or(memd[ss, ebp - 0x68], eax);          /* or [ebp-0x68], eax */
        l_0x1007_8667:
            ii(0x1007_8667, 3); mov(edx, memd[ss, ebp - 0x68]);         /* mov edx, [ebp-0x68] */
            ii(0x1007_866a, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_866d, 5); call(0x1008_a9d0, 0x1_235e);            /* call 0x1008a9d0 */
            ii(0x1007_8672, 4); shl(memd[ss, ebp - 0x64], 0x7);         /* shl dword [ebp-0x64], 0x7 */
        l_0x1007_8676:
            ii(0x1007_8676, 4); movsx(ebx, memw[ss, ebp - 0x24]);       /* movsx ebx, word [ebp-0x24] */
            ii(0x1007_867a, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1007_867d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_8680, 5); call(0x1007_cfc2, 0x493d);              /* call 0x1007cfc2 */
            ii(0x1007_8685, 3); or(memd[ss, ebp - 0x64], eax);          /* or [ebp-0x64], eax */
            ii(0x1007_8688, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_868c, 2); if(jle(0x1007_8694, 0x6)) goto l_0x1007_8694; /* jle 0x10078694 */
            ii(0x1007_868e, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1007_8692, 2); if(jz(0x1007_8696, 0x2)) goto l_0x1007_8696; /* jz 0x10078696 */
        l_0x1007_8694:
            ii(0x1007_8694, 2); jmp(0x1007_86c2, 0x2c); goto l_0x1007_86c2; /* jmp 0x100786c2 */
        l_0x1007_8696:
            ii(0x1007_8696, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1007_869b, 4); movsx(ebx, memb[ss, ebp - 0x4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x1007_869f, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_86a2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_86a5, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_86a8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_86ad, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_86b3, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1007_86b8, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_86ba, 5); call(0x100c_1fd4, 0x4_9915);            /* call 0x100c1fd4 */
            ii(0x1007_86bf, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x1007_86c2:
            ii(0x1007_86c2, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1007_86c6, 2); if(jnz(0x1007_86d1, 0x9)) goto l_0x1007_86d1; /* jnz 0x100786d1 */
            ii(0x1007_86c8, 7); mov(memd[ss, ebp - 0x6c], 0);           /* mov dword [ebp-0x6c], 0x0 */
            ii(0x1007_86cf, 2); jmp(0x1007_8705, 0x34); goto l_0x1007_8705; /* jmp 0x10078705 */
        l_0x1007_86d1:
            ii(0x1007_86d1, 4); movsx(eax, memw[ss, ebp - 0x3c]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1007_86d5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_86d8, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1007_86db, 4); movsx(edx, memw[ss, ebp - 0x3a]);       /* movsx edx, word [ebp-0x3a] */
            ii(0x1007_86df, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1007_86e1, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_86e3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_86e5, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1007_86e8, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1007_86eb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_86ee, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_86f1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_86f6, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1007_86fa, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_86fc, 2); if(jge(0x1007_8705, 0x7)) goto l_0x1007_8705; /* jge 0x10078705 */
            ii(0x1007_86fe, 7); mov(memd[ss, ebp - 0x6c], 0);           /* mov dword [ebp-0x6c], 0x0 */
        l_0x1007_8705:
            ii(0x1007_8705, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1007_8709, 2); if(jz(0x1007_8746, 0x3b)) goto l_0x1007_8746; /* jz 0x10078746 */
            ii(0x1007_870b, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1007_870e, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x1007_8712, 2); if(jg(0x1007_875d, 0x49)) goto l_0x1007_875d; /* jg 0x1007875d */
            ii(0x1007_8714, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1007_8717, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x1007_871b, 2); if(jnz(0x1007_8746, 0x29)) goto l_0x1007_8746; /* jnz 0x10078746 */
            ii(0x1007_871d, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1007_8720, 4); cmp(ax, memw[ss, ebp - 0x2c]);          /* cmp ax, [ebp-0x2c] */
            ii(0x1007_8724, 2); if(jg(0x1007_875d, 0x37)) goto l_0x1007_875d; /* jg 0x1007875d */
            ii(0x1007_8726, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1007_8729, 4); cmp(ax, memw[ss, ebp - 0x2c]);          /* cmp ax, [ebp-0x2c] */
            ii(0x1007_872d, 2); if(jnz(0x1007_8742, 0x13)) goto l_0x1007_8742; /* jnz 0x10078742 */
            ii(0x1007_872f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_8732, 5); call(0x1008_a370, 0x1_1c39);            /* call 0x1008a370 */
            ii(0x1007_8737, 3); mov(dl, memb[ds, eax + 0x4d]);          /* mov dl, [eax+0x4d] */
            ii(0x1007_873a, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_873d, 3); cmp(dl, memb[ds, eax + 0x4d]);          /* cmp dl, [eax+0x4d] */
            ii(0x1007_8740, 2); if(jb(0x1007_8744, 0x2)) goto l_0x1007_8744; /* jb 0x10078744 */
        l_0x1007_8742:
            ii(0x1007_8742, 2); jmp(0x1007_8746, 0x2); goto l_0x1007_8746; /* jmp 0x10078746 */
        l_0x1007_8744:
            ii(0x1007_8744, 2); jmp(0x1007_875d, 0x17); goto l_0x1007_875d; /* jmp 0x1007875d */
        l_0x1007_8746:
            ii(0x1007_8746, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_8749, 5); call(0x1008_a12c, 0x1_19de);            /* call 0x1008a12c */
            ii(0x1007_874e, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_8751, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1007_8754, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_8757, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1007_875a, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
        l_0x1007_875d:
            ii(0x1007_875d, 5); jmp(0x1007_8359, -0x409); goto l_0x1007_8359; /* jmp 0x10078359 */
        l_0x1007_8762:
            ii(0x1007_8762, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_8765, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x1007_8768, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_876a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_876d, 5); call(0x1008_8e4c, 0x1_06da);            /* call 0x10088e4c */
            ii(0x1007_8772, 2); jmp(0x1007_877e, 0xa); goto l_0x1007_877e; /* jmp 0x1007877e */
        //  ii(0x1007_8774, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_8776, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x1007_8779, 5); call(0x1008_8e4c, 0x1_06ce);            /* call 0x10088e4c */
        l_0x1007_877e:
            ii(0x1007_877e, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1007_8781, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_8783, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_8784, 1); pop(edi);                               /* pop edi */
            ii(0x1007_8785, 1); pop(esi);                               /* pop esi */
            ii(0x1007_8786, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
