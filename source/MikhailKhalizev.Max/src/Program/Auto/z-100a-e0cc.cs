using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_e0cc-fd0f372f")]
        public void Method_100a_e0cc()
        {
            ii(0x100a_e0cc, 5); push(0x78);                             /* push 0x78 */
            ii(0x100a_e0d1, 5); call(Definitions.sys_check_available_stack_size, 0xb_7c7c); /* call 0x10165d52 */
            ii(0x100a_e0d6, 1); push(ebx);                              /* push ebx */
            ii(0x100a_e0d7, 1); push(ecx);                              /* push ecx */
            ii(0x100a_e0d8, 1); push(esi);                              /* push esi */
            ii(0x100a_e0d9, 1); push(edi);                              /* push edi */
            ii(0x100a_e0da, 1); push(ebp);                              /* push ebp */
            ii(0x100a_e0db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_e0dd, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x100a_e0e3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_e0e6, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_e0e9, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_e0ec, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e0ef, 5); call(0x1008_b060, -0x2_3094);           /* call 0x1008b060 */
            ii(0x100a_e0f4, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_e0f7, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100a_e0fa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_e0fd, 5); call(0x1007_6d98, -0x3_736a);           /* call 0x10076d98 */
            ii(0x100a_e102, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e104, 6); if(jz(0x100a_e4d8, 0x3ce)) goto l_0x100a_e4d8; /* jz 0x100ae4d8 */
            ii(0x100a_e10a, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_e10d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_e110, 5); call(0x1015_2a52, 0xa_493d);            /* call 0x10152a52 */
            ii(0x100a_e115, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e117, 2); if(jnz(0x100a_e12c, 0x13)) goto l_0x100a_e12c; /* jnz 0x100ae12c */
            ii(0x100a_e119, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_e11d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e11f, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e122, 5); call(0x1008_8b7c, -0x2_55ab);           /* call 0x10088b7c */
            ii(0x100a_e127, 5); jmp(0x100a_e4f2, 0x3c6); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e12c:
            ii(0x100a_e12c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e12f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e132, 5); call(0x1007_6574, -0x3_7bc3);           /* call 0x10076574 */
            ii(0x100a_e137, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100a_e13a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_e13f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_e145, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100a_e14b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_e150, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_e153, 2); if(jz(0x100a_e18a, 0x35)) goto l_0x100a_e18a; /* jz 0x100ae18a */
            ii(0x100a_e155, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e158, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e15b, 5); call(0x1007_6574, -0x3_7bec);           /* call 0x10076574 */
            ii(0x100a_e160, 5); call(0x1015_287d, 0xa_4718);            /* call 0x1015287d */
            ii(0x100a_e165, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e168, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_e16b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_e16e, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_e171, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_e174, 3); call_abs(memd[ds, edx + 0x48]);         /* call dword [edx+0x48] */
            ii(0x100a_e177, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_e17b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e17d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e180, 5); call(0x1008_8b7c, -0x2_5609);           /* call 0x10088b7c */
            ii(0x100a_e185, 5); jmp(0x100a_e4f2, 0x368); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e18a:
            ii(0x100a_e18a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e18d, 4); cmp(memb[ds, eax + 0x19], 0);           /* cmp byte [eax+0x19], 0x0 */
            ii(0x100a_e191, 2); if(jle(0x100a_e199, 0x6)) goto l_0x100a_e199; /* jle 0x100ae199 */
            ii(0x100a_e193, 4); mov(memb[ss, ebp - 0x1c], 0x1);         /* mov byte [ebp-0x1c], 0x1 */
            ii(0x100a_e197, 2); jmp(0x100a_e19d, 0x4); goto l_0x100a_e19d; /* jmp 0x100ae19d */
        l_0x100a_e199:
            ii(0x100a_e199, 4); mov(memb[ss, ebp - 0x1c], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x100a_e19d:
            ii(0x100a_e19d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e19f, 3); mov(dl, memb[ss, ebp - 0x1c]);          /* mov dl, [ebp-0x1c] */
            ii(0x100a_e1a2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e1a5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e1a8, 5); call(0x1007_65d0, -0x3_7bdd);           /* call 0x100765d0 */
            ii(0x100a_e1ad, 5); call(0x1007_8840, -0x3_5972);           /* call 0x10078840 */
            ii(0x100a_e1b2, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e1b4, 2); if(jz(0x100a_e1c9, 0x13)) goto l_0x100a_e1c9; /* jz 0x100ae1c9 */
            ii(0x100a_e1b6, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_e1ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e1bc, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e1bf, 5); call(0x1008_8b7c, -0x2_5648);           /* call 0x10088b7c */
            ii(0x100a_e1c4, 5); jmp(0x100a_e4f2, 0x329); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e1c9:
            ii(0x100a_e1c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e1cb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e1ce, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e1d1, 5); call(0x1013_ad11, 0x8_cb3b);            /* call 0x1013ad11 */
            ii(0x100a_e1d6, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e1d8, 2); if(jz(0x100a_e1ed, 0x13)) goto l_0x100a_e1ed; /* jz 0x100ae1ed */
            ii(0x100a_e1da, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_e1de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e1e0, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e1e3, 5); call(0x1008_8b7c, -0x2_566c);           /* call 0x10088b7c */
            ii(0x100a_e1e8, 5); jmp(0x100a_e4f2, 0x305); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e1ed:
            ii(0x100a_e1ed, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e1f0, 5); call(0x100a_ee06, 0xc11);               /* call 0x100aee06 */
            ii(0x100a_e1f5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e1f8, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_e1fb, 5); call(Definitions.my_3_get_count, -0x2_2d80); /* call 0x1008b480 */
            ii(0x100a_e200, 1); cwde();                                 /* cwde */
            ii(0x100a_e201, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_e203, 2); if(jnz(0x100a_e22a, 0x25)) goto l_0x100a_e22a; /* jnz 0x100ae22a */
            ii(0x100a_e205, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e208, 5); cmp(memw[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_e20d, 2); if(jnz(0x100a_e217, 0x8)) goto l_0x100a_e217; /* jnz 0x100ae217 */
            ii(0x100a_e20f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e212, 5); call(0x100a_e04c, -0x1cb);              /* call 0x100ae04c */
        l_0x100a_e217:
            ii(0x100a_e217, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_e21b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e21d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e220, 5); call(0x1008_8b7c, -0x2_56a9);           /* call 0x10088b7c */
            ii(0x100a_e225, 5); jmp(0x100a_e4f2, 0x2c8); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e22a:
            ii(0x100a_e22a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e22d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e230, 5); call(0x1007_6574, -0x3_7cc1);           /* call 0x10076574 */
            ii(0x100a_e235, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100a_e238, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_e23d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_e23f, 2); if(jnz(0x100a_e273, 0x32)) goto l_0x100a_e273; /* jnz 0x100ae273 */
            ii(0x100a_e241, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e244, 4); cmp(memb[ds, eax + 0x44], 0);           /* cmp byte [eax+0x44], 0x0 */
            ii(0x100a_e248, 2); if(jz(0x100a_e254, 0xa)) goto l_0x100a_e254; /* jz 0x100ae254 */
            ii(0x100a_e24a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e24d, 5); cmp(memw[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_e252, 2); if(jz(0x100a_e256, 0x2)) goto l_0x100a_e256; /* jz 0x100ae256 */
        l_0x100a_e254:
            ii(0x100a_e254, 2); jmp(0x100a_e260, 0xa); goto l_0x100a_e260; /* jmp 0x100ae260 */
        l_0x100a_e256:
            ii(0x100a_e256, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e258, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e25b, 5); call(0x100a_d02d, -0x1233);             /* call 0x100ad02d */
        l_0x100a_e260:
            ii(0x100a_e260, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_e264, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e266, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e269, 5); call(0x1008_8b7c, -0x2_56f2);           /* call 0x10088b7c */
            ii(0x100a_e26e, 5); jmp(0x100a_e4f2, 0x27f); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e273:
            ii(0x100a_e273, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e276, 4); cmp(memb[ds, eax + 0x19], 0);           /* cmp byte [eax+0x19], 0x0 */
            ii(0x100a_e27a, 2); if(jle(0x100a_e2bc, 0x40)) goto l_0x100a_e2bc; /* jle 0x100ae2bc */
            ii(0x100a_e27c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e27f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e282, 5); call(0x1007_6574, -0x3_7d13);           /* call 0x10076574 */
            ii(0x100a_e287, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100a_e28a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_e28d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e290, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e293, 5); call(0x1007_6574, -0x3_7d24);           /* call 0x10076574 */
            ii(0x100a_e298, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100a_e29b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_e29e, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_e2a1, 5); call(0x1007_6aac, -0x3_77fa);           /* call 0x10076aac */
            ii(0x100a_e2a6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e2a8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e2ab, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e2ae, 5); call(0x1007_65d0, -0x3_7ce3);           /* call 0x100765d0 */
            ii(0x100a_e2b3, 5); call(0x100a_b5f3, -0x2cc5);             /* call 0x100ab5f3 */
            ii(0x100a_e2b8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e2ba, 2); if(jnz(0x100a_e2be, 0x2)) goto l_0x100a_e2be; /* jnz 0x100ae2be */
        l_0x100a_e2bc:
            ii(0x100a_e2bc, 2); jmp(0x100a_e32e, 0x70); goto l_0x100a_e32e; /* jmp 0x100ae32e */
        l_0x100a_e2be:
            ii(0x100a_e2be, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e2c1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e2c4, 5); call(0x1007_6574, -0x3_7d55);           /* call 0x10076574 */
            ii(0x100a_e2c9, 5); call(0x1007_623c, -0x3_8092);           /* call 0x1007623c */
            ii(0x100a_e2ce, 4); mov(ax, memw[ds, eax + 0x14]);          /* mov ax, [eax+0x14] */
            ii(0x100a_e2d2, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100a_e2d5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e2d8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e2db, 5); call(0x1007_6574, -0x3_7d6c);           /* call 0x10076574 */
            ii(0x100a_e2e0, 5); call(0x1007_623c, -0x3_80a9);           /* call 0x1007623c */
            ii(0x100a_e2e5, 4); mov(ax, memw[ds, eax + 0x10]);          /* mov ax, [eax+0x10] */
            ii(0x100a_e2e9, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100a_e2ec, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100a_e2f0, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100a_e2f4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_e2f6, 4); movsx(ebx, memw[ss, ebp - 0x24]);       /* movsx ebx, word [ebp-0x24] */
            ii(0x100a_e2fa, 1); dec(edx);                               /* dec edx */
            ii(0x100a_e2fb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_e2fd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_e300, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_e302, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e304, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e307, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e30a, 5); call(0x1007_6574, -0x3_7d9b);           /* call 0x10076574 */
            ii(0x100a_e30f, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100a_e312, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_e317, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100a_e319, 2); if(jg(0x100a_e32e, 0x13)) goto l_0x100a_e32e; /* jg 0x100ae32e */
            ii(0x100a_e31b, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_e31f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e321, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e324, 5); call(0x1008_8b7c, -0x2_57ad);           /* call 0x10088b7c */
            ii(0x100a_e329, 5); jmp(0x100a_e4f2, 0x1c4); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e32e:
            ii(0x100a_e32e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e331, 5); call(0x100a_f018, 0xce2);               /* call 0x100af018 */
            ii(0x100a_e336, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e338, 2); if(jnz(0x100a_e355, 0x1b)) goto l_0x100a_e355; /* jnz 0x100ae355 */
            ii(0x100a_e33a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e33d, 5); call(0x100a_e04c, -0x2f6);              /* call 0x100ae04c */
            ii(0x100a_e342, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_e346, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e348, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e34b, 5); call(0x1008_8b7c, -0x2_57d4);           /* call 0x10088b7c */
            ii(0x100a_e350, 5); jmp(0x100a_e4f2, 0x19d); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e355:
            ii(0x100a_e355, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e358, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e35b, 5); call(0x1007_6574, -0x3_7dec);           /* call 0x10076574 */
            ii(0x100a_e360, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x100a_e364, 2); if(jz(0x100a_e381, 0x1b)) goto l_0x100a_e381; /* jz 0x100ae381 */
            ii(0x100a_e366, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e369, 5); call(0x100a_e6e2, 0x374);               /* call 0x100ae6e2 */
            ii(0x100a_e36e, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_e372, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e374, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e377, 5); call(0x1008_8b7c, -0x2_5800);           /* call 0x10088b7c */
            ii(0x100a_e37c, 5); jmp(0x100a_e4f2, 0x171); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e381:
            ii(0x100a_e381, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e384, 5); call(0x100a_eb18, 0x78f);               /* call 0x100aeb18 */
            ii(0x100a_e389, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e38b, 2); if(jz(0x100a_e3a0, 0x13)) goto l_0x100a_e3a0; /* jz 0x100ae3a0 */
            ii(0x100a_e38d, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_e391, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e393, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e396, 5); call(0x1008_8b7c, -0x2_581f);           /* call 0x10088b7c */
            ii(0x100a_e39b, 5); jmp(0x100a_e4f2, 0x152); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e3a0:
            ii(0x100a_e3a0, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100a_e3a5, 5); call(Definitions.sys_new, 0xb_7a56);    /* call 0x10165e00 */
            ii(0x100a_e3aa, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100a_e3ad, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100a_e3b0, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100a_e3b3, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100a_e3b7, 2); if(jz(0x100a_e3ee, 0x35)) goto l_0x100a_e3ee; /* jz 0x100ae3ee */
            ii(0x100a_e3b9, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_e3bc, 3); add(edx, 0x1a);                         /* add edx, 0x1a */
            ii(0x100a_e3bf, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100a_e3c2, 5); call(0x1007_5e64, -0x3_8563);           /* call 0x10075e64 */
            ii(0x100a_e3c7, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_e3c9, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100a_e3ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e3d1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e3d4, 5); call(0x1007_65d0, -0x3_7e09);           /* call 0x100765d0 */
            ii(0x100a_e3d9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e3db, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100a_e3de, 5); call(0x100a_beeb, -0x24f8);             /* call 0x100abeeb */
            ii(0x100a_e3e3, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100a_e3e6, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100a_e3e9, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100a_e3ec, 2); jmp(0x100a_e3f4, 0x6); goto l_0x100a_e3f4; /* jmp 0x100ae3f4 */
        l_0x100a_e3ee:
            ii(0x100a_e3ee, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100a_e3f1, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
        l_0x100a_e3f4:
            ii(0x100a_e3f4, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100a_e3f7, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100a_e3fa, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100a_e3fe, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x100a_e401, 5); call(Definitions.my_ctor_0x101b_3b58, -0x2_3362); /* call 0x1008b0a4 */
            ii(0x100a_e406, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100a_e409, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100a_e40d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e410, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e413, 5); call(0x1007_6574, -0x3_7ea4);           /* call 0x10076574 */
            ii(0x100a_e418, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100a_e41b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_e41d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_e420, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_e423, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100a_e426, 5); call(0x1011_d8ba, 0x6_f48f);            /* call 0x1011d8ba */
            ii(0x100a_e42b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e42e, 3); mov(edx, memd[ds, eax + 0x16]);         /* mov edx, [eax+0x16] */
            ii(0x100a_e431, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100a_e434, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100a_e437, 5); call(0x1011_d801, 0x6_f3c5);            /* call 0x1011d801 */
            ii(0x100a_e43c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e43f, 4); cmp(memb[ds, eax + 0x19], 0);           /* cmp byte [eax+0x19], 0x0 */
            ii(0x100a_e443, 2); if(jle(0x100a_e44b, 0x6)) goto l_0x100a_e44b; /* jle 0x100ae44b */
            ii(0x100a_e445, 4); mov(memb[ss, ebp - 0x4c], 0x1);         /* mov byte [ebp-0x4c], 0x1 */
            ii(0x100a_e449, 2); jmp(0x100a_e44f, 0x4); goto l_0x100a_e44f; /* jmp 0x100ae44f */
        l_0x100a_e44b:
            ii(0x100a_e44b, 4); mov(memb[ss, ebp - 0x4c], 0);           /* mov byte [ebp-0x4c], 0x0 */
        l_0x100a_e44f:
            ii(0x100a_e44f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e451, 3); mov(dl, memb[ss, ebp - 0x4c]);          /* mov dl, [ebp-0x4c] */
            ii(0x100a_e454, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100a_e457, 5); call(0x1011_d88c, 0x6_f430);            /* call 0x1011d88c */
            ii(0x100a_e45c, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_e461, 5); call(Definitions.sys_new, 0xb_799a);    /* call 0x10165e00 */
            ii(0x100a_e466, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100a_e469, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x100a_e46c, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x100a_e46f, 4); cmp(memd[ss, ebp - 0x54], 0);           /* cmp dword [ebp-0x54], 0x0 */
            ii(0x100a_e473, 2); if(jz(0x100a_e499, 0x24)) goto l_0x100a_e499; /* jz 0x100ae499 */
            ii(0x100a_e475, 5); mov(eax, 0x100a_d995);                  /* mov eax, 0x100ad995 */
            ii(0x100a_e47a, 1); push(eax);                              /* push eax */
            ii(0x100a_e47b, 5); mov(ecx, 0x100a_f2a7);                  /* mov ecx, 0x100af2a7 */
            ii(0x100a_e480, 3); mov(ebx, memd[ss, ebp - 0x40]);         /* mov ebx, [ebp-0x40] */
            ii(0x100a_e483, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_e486, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x100a_e489, 5); call(0x100a_ba72, -0x2a1c);             /* call 0x100aba72 */
            ii(0x100a_e48e, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x100a_e491, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100a_e494, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100a_e497, 2); jmp(0x100a_e49f, 0x6); goto l_0x100a_e49f; /* jmp 0x100ae49f */
        l_0x100a_e499:
            ii(0x100a_e499, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x100a_e49c, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
        l_0x100a_e49f:
            ii(0x100a_e49f, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x100a_e4a2, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x100a_e4a5, 5); call(0x1008_afe4, -0x2_34c6);           /* call 0x1008afe4 */
            ii(0x100a_e4aa, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x100a_e4ad, 5); call(0x1008_af84, -0x2_352e);           /* call 0x1008af84 */
            ii(0x100a_e4b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e4b4, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_e4b9, 5); call(0x100a_4d50, -0x976e);             /* call 0x100a4d50 */
            ii(0x100a_e4be, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_e4c2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e4c4, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x100a_e4c7, 5); call(0x1008_8b7c, -0x2_5950);           /* call 0x10088b7c */
            ii(0x100a_e4cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e4ce, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e4d1, 5); call(0x1008_8b7c, -0x2_595a);           /* call 0x10088b7c */
            ii(0x100a_e4d6, 2); jmp(0x100a_e4f2, 0x1a); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        l_0x100a_e4d8:
            ii(0x100a_e4d8, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_e4dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e4de, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e4e1, 5); call(0x1008_8b7c, -0x2_596a);           /* call 0x10088b7c */
            ii(0x100a_e4e6, 2); jmp(0x100a_e4f2, 0xa); goto l_0x100a_e4f2; /* jmp 0x100ae4f2 */
        //  ii(0x100a_e4e8, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_e4ea, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
        //  ii(0x100a_e4ed, 5); call(0x1008_8b7c, -0x2_5976);           /* call 0x10088b7c */
        l_0x100a_e4f2:
            ii(0x100a_e4f2, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x100a_e4f5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_e4f7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_e4f8, 1); pop(edi);                               /* pop edi */
            ii(0x100a_e4f9, 1); pop(esi);                               /* pop esi */
            ii(0x100a_e4fa, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_e4fb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_e4fc, 1); ret();                                  /* ret */
        }
    }
}
