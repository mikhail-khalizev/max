using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_b2ee-e81352db")]
        public void Method_100d_b2ee()
        {
            ii(0x100d_b2ee, 5); push(0x174);                            /* push 0x174 */
            ii(0x100d_b2f3, 5); call(Definitions.sys_check_available_stack_size, 0x8_aa5a); /* call 0x10165d52 */
            ii(0x100d_b2f8, 1); push(ecx);                              /* push ecx */
            ii(0x100d_b2f9, 1); push(esi);                              /* push esi */
            ii(0x100d_b2fa, 1); push(edi);                              /* push edi */
            ii(0x100d_b2fb, 1); push(ebp);                              /* push ebp */
            ii(0x100d_b2fc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_b2fe, 6); sub(esp, 0x148);                        /* sub esp, 0x148 */
            ii(0x100d_b304, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_b307, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_b30a, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100d_b30d, 5); mov(ebx, 0x6ca);                        /* mov ebx, 0x6ca */
            ii(0x100d_b312, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_b316, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b319, 5); call(0x100d_8f7b, -0x23a3);             /* call 0x100d8f7b */
            ii(0x100d_b31e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_b321, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100d_b324, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_b327, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_b32a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b32d, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_b332, 5); call(0x1007_6954, -0x6_49e3);           /* call 0x10076954 */
            ii(0x100d_b337, 5); sub(eax, 0x3af);                        /* sub eax, 0x3af */
            ii(0x100d_b33c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_b33f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100d_b342, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_b345, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b348, 7); mov(memd[ds, eax + 0x13], 0x101b_5f2c); /* mov dword [eax+0x13], 0x101b5f2c */
            ii(0x100d_b34f, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_b354, 5); call(Definitions.sys_new, 0x8_aaa7);    /* call 0x10165e00 */
            ii(0x100d_b359, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_b35c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_b35f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_b362, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100d_b366, 2); if(jz(0x100d_b390, 0x28)) goto l_0x100d_b390; /* jz 0x100db390 */
            ii(0x100d_b368, 5); mov(eax, 0xae);                         /* mov eax, 0xae */
            ii(0x100d_b36d, 1); push(eax);                              /* push eax */
            ii(0x100d_b36e, 5); mov(ecx, 0xfa);                         /* mov ecx, 0xfa */
            ii(0x100d_b373, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_b378, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x100d_b37d, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_b380, 5); call(0x100d_7bdc, -0x37a9);             /* call 0x100d7bdc */
            ii(0x100d_b385, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_b388, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_b38b, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_b38e, 2); jmp(0x100d_b396, 0x6); goto l_0x100d_b396; /* jmp 0x100db396 */
        l_0x100d_b390:
            ii(0x100d_b390, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_b393, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x100d_b396:
            ii(0x100d_b396, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_b399, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b39c, 6); mov(memd[ds, edx + 0x39f], eax);        /* mov [edx+0x39f], eax */
            ii(0x100d_b3a2, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_b3a7, 5); call(Definitions.sys_new, 0x8_aa54);    /* call 0x10165e00 */
            ii(0x100d_b3ac, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_b3af, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_b3b2, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_b3b5, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100d_b3b9, 2); if(jz(0x100d_b3e3, 0x28)) goto l_0x100d_b3e3; /* jz 0x100db3e3 */
            ii(0x100d_b3bb, 5); mov(eax, 0xae);                         /* mov eax, 0xae */
            ii(0x100d_b3c0, 1); push(eax);                              /* push eax */
            ii(0x100d_b3c1, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x100d_b3c6, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_b3cb, 5); mov(edx, 0x141);                        /* mov edx, 0x141 */
            ii(0x100d_b3d0, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_b3d3, 5); call(0x100d_7bdc, -0x37fc);             /* call 0x100d7bdc */
            ii(0x100d_b3d8, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_b3db, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_b3de, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_b3e1, 2); jmp(0x100d_b3e9, 0x6); goto l_0x100d_b3e9; /* jmp 0x100db3e9 */
        l_0x100d_b3e3:
            ii(0x100d_b3e3, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100d_b3e6, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
        l_0x100d_b3e9:
            ii(0x100d_b3e9, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_b3ec, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b3ef, 6); mov(memd[ds, edx + 0x3a3], eax);        /* mov [edx+0x3a3], eax */
            ii(0x100d_b3f5, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_b3fa, 5); call(Definitions.sys_new, 0x8_aa01);    /* call 0x10165e00 */
            ii(0x100d_b3ff, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100d_b402, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_b405, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100d_b408, 4); cmp(memd[ss, ebp - 0x3c], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100d_b40c, 2); if(jz(0x100d_b436, 0x28)) goto l_0x100d_b436; /* jz 0x100db436 */
            ii(0x100d_b40e, 5); mov(eax, 0xae);                         /* mov eax, 0xae */
            ii(0x100d_b413, 1); push(eax);                              /* push eax */
            ii(0x100d_b414, 5); mov(ecx, 0x26);                         /* mov ecx, 0x26 */
            ii(0x100d_b419, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_b41e, 5); mov(edx, 0x11b);                        /* mov edx, 0x11b */
            ii(0x100d_b423, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_b426, 5); call(0x100d_7bdc, -0x384f);             /* call 0x100d7bdc */
            ii(0x100d_b42b, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100d_b42e, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100d_b431, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100d_b434, 2); jmp(0x100d_b43c, 0x6); goto l_0x100d_b43c; /* jmp 0x100db43c */
        l_0x100d_b436:
            ii(0x100d_b436, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100d_b439, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
        l_0x100d_b43c:
            ii(0x100d_b43c, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100d_b43f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b442, 6); mov(memd[ds, edx + 0x3ab], eax);        /* mov [edx+0x3ab], eax */
            ii(0x100d_b448, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_b44d, 5); call(Definitions.sys_new, 0x8_a9ae);    /* call 0x10165e00 */
            ii(0x100d_b452, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100d_b455, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100d_b458, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_b45b, 4); cmp(memd[ss, ebp - 0x4c], 0);           /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100d_b45f, 2); if(jz(0x100d_b489, 0x28)) goto l_0x100d_b489; /* jz 0x100db489 */
            ii(0x100d_b461, 5); mov(eax, 0x8c);                         /* mov eax, 0x8c */
            ii(0x100d_b466, 1); push(eax);                              /* push eax */
            ii(0x100d_b467, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x100d_b46c, 5); mov(ebx, 0x114);                        /* mov ebx, 0x114 */
            ii(0x100d_b471, 5); mov(edx, 0x169);                        /* mov edx, 0x169 */
            ii(0x100d_b476, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100d_b479, 5); call(0x100d_7bdc, -0x38a2);             /* call 0x100d7bdc */
            ii(0x100d_b47e, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_b481, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_b484, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_b487, 2); jmp(0x100d_b48f, 0x6); goto l_0x100d_b48f; /* jmp 0x100db48f */
        l_0x100d_b489:
            ii(0x100d_b489, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_b48c, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
        l_0x100d_b48f:
            ii(0x100d_b48f, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_b492, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b495, 6); mov(memd[ds, edx + 0x3a7], eax);        /* mov [edx+0x3a7], eax */
            ii(0x100d_b49b, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b4a0, 5); call(Definitions.sys_new, 0x8_a95b);    /* call 0x10165e00 */
            ii(0x100d_b4a5, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_b4a8, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_b4ab, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_b4ae, 4); cmp(memd[ss, ebp - 0x5c], 0);           /* cmp dword [ebp-0x5c], 0x0 */
            ii(0x100d_b4b2, 2); if(jz(0x100d_b4dc, 0x28)) goto l_0x100d_b4dc; /* jz 0x100db4dc */
            ii(0x100d_b4b4, 5); mov(eax, 0x183);                        /* mov eax, 0x183 */
            ii(0x100d_b4b9, 1); push(eax);                              /* push eax */
            ii(0x100d_b4ba, 5); mov(ecx, 0x1d7);                        /* mov ecx, 0x1d7 */
            ii(0x100d_b4bf, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x100d_b4c4, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x100d_b4c9, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_b4cc, 5); call(Definitions.my_ctor_c17, -0xd0c2); /* call 0x100ce40f */
            ii(0x100d_b4d1, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_b4d4, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_b4d7, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x100d_b4da, 2); jmp(0x100d_b4e2, 0x6); goto l_0x100d_b4e2; /* jmp 0x100db4e2 */
        l_0x100d_b4dc:
            ii(0x100d_b4dc, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x100d_b4df, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
        l_0x100d_b4e2:
            ii(0x100d_b4e2, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x100d_b4e5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b4e8, 6); mov(memd[ds, edx + 0x349], eax);        /* mov [edx+0x349], eax */
            ii(0x100d_b4ee, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b4f3, 5); call(Definitions.sys_new, 0x8_a908);    /* call 0x10165e00 */
            ii(0x100d_b4f8, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x100d_b4fb, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x100d_b4fe, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x100d_b501, 4); cmp(memd[ss, ebp - 0x6c], 0);           /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x100d_b505, 2); if(jz(0x100d_b52f, 0x28)) goto l_0x100d_b52f; /* jz 0x100db52f */
            ii(0x100d_b507, 5); mov(eax, 0x183);                        /* mov eax, 0x183 */
            ii(0x100d_b50c, 1); push(eax);                              /* push eax */
            ii(0x100d_b50d, 5); mov(ecx, 0x1eb);                        /* mov ecx, 0x1eb */
            ii(0x100d_b512, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x100d_b517, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x100d_b51c, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x100d_b51f, 5); call(Definitions.my_ctor_c17, -0xd115); /* call 0x100ce40f */
            ii(0x100d_b524, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x100d_b527, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x100d_b52a, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x100d_b52d, 2); jmp(0x100d_b535, 0x6); goto l_0x100d_b535; /* jmp 0x100db535 */
        l_0x100d_b52f:
            ii(0x100d_b52f, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100d_b532, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
        l_0x100d_b535:
            ii(0x100d_b535, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x100d_b538, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b53b, 6); mov(memd[ds, edx + 0x34d], eax);        /* mov [edx+0x34d], eax */
            ii(0x100d_b541, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b546, 5); call(Definitions.sys_new, 0x8_a8b5);    /* call 0x10165e00 */
            ii(0x100d_b54b, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x100d_b54e, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x100d_b551, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x100d_b554, 4); cmp(memd[ss, ebp - 0x7c], 0);           /* cmp dword [ebp-0x7c], 0x0 */
            ii(0x100d_b558, 2); if(jz(0x100d_b585, 0x2b)) goto l_0x100d_b585; /* jz 0x100db585 */
            ii(0x100d_b55a, 5); mov(eax, 0x108);                        /* mov eax, 0x108 */
            ii(0x100d_b55f, 1); push(eax);                              /* push eax */
            ii(0x100d_b560, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_b565, 5); mov(ebx, 0x129);                        /* mov ebx, 0x129 */
            ii(0x100d_b56a, 5); mov(edx, 0x128);                        /* mov edx, 0x128 */
            ii(0x100d_b56f, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x100d_b572, 5); call(Definitions.my_ctor_c17, -0xd168); /* call 0x100ce40f */
            ii(0x100d_b577, 3); mov(memd[ss, ebp - 0x80], eax);         /* mov [ebp-0x80], eax */
            ii(0x100d_b57a, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x100d_b57d, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
            ii(0x100d_b583, 2); jmp(0x100d_b58e, 0x9); goto l_0x100d_b58e; /* jmp 0x100db58e */
        l_0x100d_b585:
            ii(0x100d_b585, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x100d_b588, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
        l_0x100d_b58e:
            ii(0x100d_b58e, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x100d_b594, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b597, 6); mov(memd[ds, edx + 0x371], eax);        /* mov [edx+0x371], eax */
            ii(0x100d_b59d, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b5a2, 5); call(Definitions.sys_new, 0x8_a859);    /* call 0x10165e00 */
            ii(0x100d_b5a7, 6); mov(memd[ss, ebp - 0x88], eax);         /* mov [ebp-0x88], eax */
            ii(0x100d_b5ad, 6); mov(eax, memd[ss, ebp - 0x88]);         /* mov eax, [ebp-0x88] */
            ii(0x100d_b5b3, 6); mov(memd[ss, ebp - 0x8c], eax);         /* mov [ebp-0x8c], eax */
            ii(0x100d_b5b9, 7); cmp(memd[ss, ebp - 0x8c], 0);           /* cmp dword [ebp-0x8c], 0x0 */
            ii(0x100d_b5c0, 2); if(jz(0x100d_b5f6, 0x34)) goto l_0x100d_b5f6; /* jz 0x100db5f6 */
            ii(0x100d_b5c2, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_b5c7, 1); push(eax);                              /* push eax */
            ii(0x100d_b5c8, 5); mov(ecx, 0x1bf);                        /* mov ecx, 0x1bf */
            ii(0x100d_b5cd, 5); mov(ebx, 0x123);                        /* mov ebx, 0x123 */
            ii(0x100d_b5d2, 5); mov(edx, 0x122);                        /* mov edx, 0x122 */
            ii(0x100d_b5d7, 6); mov(eax, memd[ss, ebp - 0x88]);         /* mov eax, [ebp-0x88] */
            ii(0x100d_b5dd, 5); call(Definitions.my_ctor_c17, -0xd1d3); /* call 0x100ce40f */
            ii(0x100d_b5e2, 6); mov(memd[ss, ebp - 0x90], eax);         /* mov [ebp-0x90], eax */
            ii(0x100d_b5e8, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x100d_b5ee, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x100d_b5f4, 2); jmp(0x100d_b602, 0xc); goto l_0x100d_b602; /* jmp 0x100db602 */
        l_0x100d_b5f6:
            ii(0x100d_b5f6, 6); mov(eax, memd[ss, ebp - 0x8c]);         /* mov eax, [ebp-0x8c] */
            ii(0x100d_b5fc, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
        l_0x100d_b602:
            ii(0x100d_b602, 6); mov(eax, memd[ss, ebp - 0x94]);         /* mov eax, [ebp-0x94] */
            ii(0x100d_b608, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b60b, 6); mov(memd[ds, edx + 0x351], eax);        /* mov [edx+0x351], eax */
            ii(0x100d_b611, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b616, 5); call(Definitions.sys_new, 0x8_a7e5);    /* call 0x10165e00 */
            ii(0x100d_b61b, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x100d_b621, 6); mov(eax, memd[ss, ebp - 0x98]);         /* mov eax, [ebp-0x98] */
            ii(0x100d_b627, 6); mov(memd[ss, ebp - 0x9c], eax);         /* mov [ebp-0x9c], eax */
            ii(0x100d_b62d, 7); cmp(memd[ss, ebp - 0x9c], 0);           /* cmp dword [ebp-0x9c], 0x0 */
            ii(0x100d_b634, 2); if(jz(0x100d_b66a, 0x34)) goto l_0x100d_b66a; /* jz 0x100db66a */
            ii(0x100d_b636, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_b63b, 1); push(eax);                              /* push eax */
            ii(0x100d_b63c, 5); mov(ecx, 0x1a4);                        /* mov ecx, 0x1a4 */
            ii(0x100d_b641, 5); mov(ebx, 0x12d);                        /* mov ebx, 0x12d */
            ii(0x100d_b646, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x100d_b64b, 6); mov(eax, memd[ss, ebp - 0x98]);         /* mov eax, [ebp-0x98] */
            ii(0x100d_b651, 5); call(Definitions.my_ctor_c17, -0xd247); /* call 0x100ce40f */
            ii(0x100d_b656, 6); mov(memd[ss, ebp - 0xa0], eax);         /* mov [ebp-0xa0], eax */
            ii(0x100d_b65c, 6); mov(eax, memd[ss, ebp - 0xa0]);         /* mov eax, [ebp-0xa0] */
            ii(0x100d_b662, 6); mov(memd[ss, ebp - 0xa4], eax);         /* mov [ebp-0xa4], eax */
            ii(0x100d_b668, 2); jmp(0x100d_b676, 0xc); goto l_0x100d_b676; /* jmp 0x100db676 */
        l_0x100d_b66a:
            ii(0x100d_b66a, 6); mov(eax, memd[ss, ebp - 0x9c]);         /* mov eax, [ebp-0x9c] */
            ii(0x100d_b670, 6); mov(memd[ss, ebp - 0xa4], eax);         /* mov [ebp-0xa4], eax */
        l_0x100d_b676:
            ii(0x100d_b676, 6); mov(eax, memd[ss, ebp - 0xa4]);         /* mov eax, [ebp-0xa4] */
            ii(0x100d_b67c, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b67f, 6); mov(memd[ds, edx + 0x355], eax);        /* mov [edx+0x355], eax */
            ii(0x100d_b685, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b68a, 5); call(Definitions.sys_new, 0x8_a771);    /* call 0x10165e00 */
            ii(0x100d_b68f, 6); mov(memd[ss, ebp - 0xa8], eax);         /* mov [ebp-0xa8], eax */
            ii(0x100d_b695, 6); mov(eax, memd[ss, ebp - 0xa8]);         /* mov eax, [ebp-0xa8] */
            ii(0x100d_b69b, 6); mov(memd[ss, ebp - 0xac], eax);         /* mov [ebp-0xac], eax */
            ii(0x100d_b6a1, 7); cmp(memd[ss, ebp - 0xac], 0);           /* cmp dword [ebp-0xac], 0x0 */
            ii(0x100d_b6a8, 2); if(jz(0x100d_b6de, 0x34)) goto l_0x100d_b6de; /* jz 0x100db6de */
            ii(0x100d_b6aa, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_b6af, 1); push(eax);                              /* push eax */
            ii(0x100d_b6b0, 5); mov(ecx, 0x165);                        /* mov ecx, 0x165 */
            ii(0x100d_b6b5, 5); mov(ebx, 0x12b);                        /* mov ebx, 0x12b */
            ii(0x100d_b6ba, 5); mov(edx, 0x12a);                        /* mov edx, 0x12a */
            ii(0x100d_b6bf, 6); mov(eax, memd[ss, ebp - 0xa8]);         /* mov eax, [ebp-0xa8] */
            ii(0x100d_b6c5, 5); call(Definitions.my_ctor_c17, -0xd2bb); /* call 0x100ce40f */
            ii(0x100d_b6ca, 6); mov(memd[ss, ebp - 0xb0], eax);         /* mov [ebp-0xb0], eax */
            ii(0x100d_b6d0, 6); mov(eax, memd[ss, ebp - 0xb0]);         /* mov eax, [ebp-0xb0] */
            ii(0x100d_b6d6, 6); mov(memd[ss, ebp - 0xb4], eax);         /* mov [ebp-0xb4], eax */
            ii(0x100d_b6dc, 2); jmp(0x100d_b6ea, 0xc); goto l_0x100d_b6ea; /* jmp 0x100db6ea */
        l_0x100d_b6de:
            ii(0x100d_b6de, 6); mov(eax, memd[ss, ebp - 0xac]);         /* mov eax, [ebp-0xac] */
            ii(0x100d_b6e4, 6); mov(memd[ss, ebp - 0xb4], eax);         /* mov [ebp-0xb4], eax */
        l_0x100d_b6ea:
            ii(0x100d_b6ea, 6); mov(eax, memd[ss, ebp - 0xb4]);         /* mov eax, [ebp-0xb4] */
            ii(0x100d_b6f0, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b6f3, 6); mov(memd[ds, edx + 0x359], eax);        /* mov [edx+0x359], eax */
            ii(0x100d_b6f9, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b6fe, 5); call(Definitions.sys_new, 0x8_a6fd);    /* call 0x10165e00 */
            ii(0x100d_b703, 6); mov(memd[ss, ebp - 0xb8], eax);         /* mov [ebp-0xb8], eax */
            ii(0x100d_b709, 6); mov(eax, memd[ss, ebp - 0xb8]);         /* mov eax, [ebp-0xb8] */
            ii(0x100d_b70f, 6); mov(memd[ss, ebp - 0xbc], eax);         /* mov [ebp-0xbc], eax */
            ii(0x100d_b715, 7); cmp(memd[ss, ebp - 0xbc], 0);           /* cmp dword [ebp-0xbc], 0x0 */
            ii(0x100d_b71c, 2); if(jz(0x100d_b752, 0x34)) goto l_0x100d_b752; /* jz 0x100db752 */
            ii(0x100d_b71e, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_b723, 1); push(eax);                              /* push eax */
            ii(0x100d_b724, 5); mov(ecx, 0x1d3);                        /* mov ecx, 0x1d3 */
            ii(0x100d_b729, 5); mov(ebx, 0x141);                        /* mov ebx, 0x141 */
            ii(0x100d_b72e, 5); mov(edx, 0x140);                        /* mov edx, 0x140 */
            ii(0x100d_b733, 6); mov(eax, memd[ss, ebp - 0xb8]);         /* mov eax, [ebp-0xb8] */
            ii(0x100d_b739, 5); call(Definitions.my_ctor_c17, -0xd32f); /* call 0x100ce40f */
            ii(0x100d_b73e, 6); mov(memd[ss, ebp - 0xc0], eax);         /* mov [ebp-0xc0], eax */
            ii(0x100d_b744, 6); mov(eax, memd[ss, ebp - 0xc0]);         /* mov eax, [ebp-0xc0] */
            ii(0x100d_b74a, 6); mov(memd[ss, ebp - 0xc4], eax);         /* mov [ebp-0xc4], eax */
            ii(0x100d_b750, 2); jmp(0x100d_b75e, 0xc); goto l_0x100d_b75e; /* jmp 0x100db75e */
        l_0x100d_b752:
            ii(0x100d_b752, 6); mov(eax, memd[ss, ebp - 0xbc]);         /* mov eax, [ebp-0xbc] */
            ii(0x100d_b758, 6); mov(memd[ss, ebp - 0xc4], eax);         /* mov [ebp-0xc4], eax */
        l_0x100d_b75e:
            ii(0x100d_b75e, 6); mov(eax, memd[ss, ebp - 0xc4]);         /* mov eax, [ebp-0xc4] */
            ii(0x100d_b764, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b767, 6); mov(memd[ds, edx + 0x35d], eax);        /* mov [edx+0x35d], eax */
            ii(0x100d_b76d, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b772, 5); call(Definitions.sys_new, 0x8_a689);    /* call 0x10165e00 */
            ii(0x100d_b777, 6); mov(memd[ss, ebp - 0xc8], eax);         /* mov [ebp-0xc8], eax */
            ii(0x100d_b77d, 6); mov(eax, memd[ss, ebp - 0xc8]);         /* mov eax, [ebp-0xc8] */
            ii(0x100d_b783, 6); mov(memd[ss, ebp - 0xcc], eax);         /* mov [ebp-0xcc], eax */
            ii(0x100d_b789, 7); cmp(memd[ss, ebp - 0xcc], 0);           /* cmp dword [ebp-0xcc], 0x0 */
            ii(0x100d_b790, 2); if(jz(0x100d_b7c6, 0x34)) goto l_0x100d_b7c6; /* jz 0x100db7c6 */
            ii(0x100d_b792, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_b797, 1); push(eax);                              /* push eax */
            ii(0x100d_b798, 5); mov(ecx, 0x1f4);                        /* mov ecx, 0x1f4 */
            ii(0x100d_b79d, 5); mov(ebx, 0x143);                        /* mov ebx, 0x143 */
            ii(0x100d_b7a2, 5); mov(edx, 0x142);                        /* mov edx, 0x142 */
            ii(0x100d_b7a7, 6); mov(eax, memd[ss, ebp - 0xc8]);         /* mov eax, [ebp-0xc8] */
            ii(0x100d_b7ad, 5); call(Definitions.my_ctor_c17, -0xd3a3); /* call 0x100ce40f */
            ii(0x100d_b7b2, 6); mov(memd[ss, ebp - 0xd0], eax);         /* mov [ebp-0xd0], eax */
            ii(0x100d_b7b8, 6); mov(eax, memd[ss, ebp - 0xd0]);         /* mov eax, [ebp-0xd0] */
            ii(0x100d_b7be, 6); mov(memd[ss, ebp - 0xd4], eax);         /* mov [ebp-0xd4], eax */
            ii(0x100d_b7c4, 2); jmp(0x100d_b7d2, 0xc); goto l_0x100d_b7d2; /* jmp 0x100db7d2 */
        l_0x100d_b7c6:
            ii(0x100d_b7c6, 6); mov(eax, memd[ss, ebp - 0xcc]);         /* mov eax, [ebp-0xcc] */
            ii(0x100d_b7cc, 6); mov(memd[ss, ebp - 0xd4], eax);         /* mov [ebp-0xd4], eax */
        l_0x100d_b7d2:
            ii(0x100d_b7d2, 6); mov(eax, memd[ss, ebp - 0xd4]);         /* mov eax, [ebp-0xd4] */
            ii(0x100d_b7d8, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b7db, 6); mov(memd[ds, edx + 0x361], eax);        /* mov [edx+0x361], eax */
            ii(0x100d_b7e1, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b7e6, 5); call(Definitions.sys_new, 0x8_a615);    /* call 0x10165e00 */
            ii(0x100d_b7eb, 6); mov(memd[ss, ebp - 0xd8], eax);         /* mov [ebp-0xd8], eax */
            ii(0x100d_b7f1, 6); mov(eax, memd[ss, ebp - 0xd8]);         /* mov eax, [ebp-0xd8] */
            ii(0x100d_b7f7, 6); mov(memd[ss, ebp - 0xdc], eax);         /* mov [ebp-0xdc], eax */
            ii(0x100d_b7fd, 7); cmp(memd[ss, ebp - 0xdc], 0);           /* cmp dword [ebp-0xdc], 0x0 */
            ii(0x100d_b804, 2); if(jz(0x100d_b83a, 0x34)) goto l_0x100d_b83a; /* jz 0x100db83a */
            ii(0x100d_b806, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_b80b, 1); push(eax);                              /* push eax */
            ii(0x100d_b80c, 5); mov(ecx, 0x215);                        /* mov ecx, 0x215 */
            ii(0x100d_b811, 5); mov(ebx, 0x145);                        /* mov ebx, 0x145 */
            ii(0x100d_b816, 5); mov(edx, 0x144);                        /* mov edx, 0x144 */
            ii(0x100d_b81b, 6); mov(eax, memd[ss, ebp - 0xd8]);         /* mov eax, [ebp-0xd8] */
            ii(0x100d_b821, 5); call(Definitions.my_ctor_c17, -0xd417); /* call 0x100ce40f */
            ii(0x100d_b826, 6); mov(memd[ss, ebp - 0xe0], eax);         /* mov [ebp-0xe0], eax */
            ii(0x100d_b82c, 6); mov(eax, memd[ss, ebp - 0xe0]);         /* mov eax, [ebp-0xe0] */
            ii(0x100d_b832, 6); mov(memd[ss, ebp - 0xe4], eax);         /* mov [ebp-0xe4], eax */
            ii(0x100d_b838, 2); jmp(0x100d_b846, 0xc); goto l_0x100d_b846; /* jmp 0x100db846 */
        l_0x100d_b83a:
            ii(0x100d_b83a, 6); mov(eax, memd[ss, ebp - 0xdc]);         /* mov eax, [ebp-0xdc] */
            ii(0x100d_b840, 6); mov(memd[ss, ebp - 0xe4], eax);         /* mov [ebp-0xe4], eax */
        l_0x100d_b846:
            ii(0x100d_b846, 6); mov(eax, memd[ss, ebp - 0xe4]);         /* mov eax, [ebp-0xe4] */
            ii(0x100d_b84c, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b84f, 6); mov(memd[ds, edx + 0x365], eax);        /* mov [edx+0x365], eax */
            ii(0x100d_b855, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b85a, 5); call(Definitions.sys_new, 0x8_a5a1);    /* call 0x10165e00 */
            ii(0x100d_b85f, 6); mov(memd[ss, ebp - 0xe8], eax);         /* mov [ebp-0xe8], eax */
            ii(0x100d_b865, 6); mov(eax, memd[ss, ebp - 0xe8]);         /* mov eax, [ebp-0xe8] */
            ii(0x100d_b86b, 6); mov(memd[ss, ebp - 0xec], eax);         /* mov [ebp-0xec], eax */
            ii(0x100d_b871, 7); cmp(memd[ss, ebp - 0xec], 0);           /* cmp dword [ebp-0xec], 0x0 */
            ii(0x100d_b878, 2); if(jz(0x100d_b8ae, 0x34)) goto l_0x100d_b8ae; /* jz 0x100db8ae */
            ii(0x100d_b87a, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_b87f, 1); push(eax);                              /* push eax */
            ii(0x100d_b880, 5); mov(ecx, 0x235);                        /* mov ecx, 0x235 */
            ii(0x100d_b885, 5); mov(ebx, 0x147);                        /* mov ebx, 0x147 */
            ii(0x100d_b88a, 5); mov(edx, 0x146);                        /* mov edx, 0x146 */
            ii(0x100d_b88f, 6); mov(eax, memd[ss, ebp - 0xe8]);         /* mov eax, [ebp-0xe8] */
            ii(0x100d_b895, 5); call(Definitions.my_ctor_c17, -0xd48b); /* call 0x100ce40f */
            ii(0x100d_b89a, 6); mov(memd[ss, ebp - 0xf0], eax);         /* mov [ebp-0xf0], eax */
            ii(0x100d_b8a0, 6); mov(eax, memd[ss, ebp - 0xf0]);         /* mov eax, [ebp-0xf0] */
            ii(0x100d_b8a6, 6); mov(memd[ss, ebp - 0xf4], eax);         /* mov [ebp-0xf4], eax */
            ii(0x100d_b8ac, 2); jmp(0x100d_b8ba, 0xc); goto l_0x100d_b8ba; /* jmp 0x100db8ba */
        l_0x100d_b8ae:
            ii(0x100d_b8ae, 6); mov(eax, memd[ss, ebp - 0xec]);         /* mov eax, [ebp-0xec] */
            ii(0x100d_b8b4, 6); mov(memd[ss, ebp - 0xf4], eax);         /* mov [ebp-0xf4], eax */
        l_0x100d_b8ba:
            ii(0x100d_b8ba, 6); mov(eax, memd[ss, ebp - 0xf4]);         /* mov eax, [ebp-0xf4] */
            ii(0x100d_b8c0, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b8c3, 6); mov(memd[ds, edx + 0x369], eax);        /* mov [edx+0x369], eax */
            ii(0x100d_b8c9, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_b8ce, 5); call(Definitions.sys_new, 0x8_a52d);    /* call 0x10165e00 */
            ii(0x100d_b8d3, 6); mov(memd[ss, ebp - 0xf8], eax);         /* mov [ebp-0xf8], eax */
            ii(0x100d_b8d9, 6); mov(eax, memd[ss, ebp - 0xf8]);         /* mov eax, [ebp-0xf8] */
            ii(0x100d_b8df, 6); mov(memd[ss, ebp - 0xfc], eax);         /* mov [ebp-0xfc], eax */
            ii(0x100d_b8e5, 7); cmp(memd[ss, ebp - 0xfc], 0);           /* cmp dword [ebp-0xfc], 0x0 */
            ii(0x100d_b8ec, 2); if(jz(0x100d_b922, 0x34)) goto l_0x100d_b922; /* jz 0x100db922 */
            ii(0x100d_b8ee, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_b8f3, 1); push(eax);                              /* push eax */
            ii(0x100d_b8f4, 5); mov(ecx, 0x256);                        /* mov ecx, 0x256 */
            ii(0x100d_b8f9, 5); mov(ebx, 0x149);                        /* mov ebx, 0x149 */
            ii(0x100d_b8fe, 5); mov(edx, 0x148);                        /* mov edx, 0x148 */
            ii(0x100d_b903, 6); mov(eax, memd[ss, ebp - 0xf8]);         /* mov eax, [ebp-0xf8] */
            ii(0x100d_b909, 5); call(Definitions.my_ctor_c17, -0xd4ff); /* call 0x100ce40f */
            ii(0x100d_b90e, 6); mov(memd[ss, ebp - 0x100], eax);        /* mov [ebp-0x100], eax */
            ii(0x100d_b914, 6); mov(eax, memd[ss, ebp - 0x100]);        /* mov eax, [ebp-0x100] */
            ii(0x100d_b91a, 6); mov(memd[ss, ebp - 0x104], eax);        /* mov [ebp-0x104], eax */
            ii(0x100d_b920, 2); jmp(0x100d_b92e, 0xc); goto l_0x100d_b92e; /* jmp 0x100db92e */
        l_0x100d_b922:
            ii(0x100d_b922, 6); mov(eax, memd[ss, ebp - 0xfc]);         /* mov eax, [ebp-0xfc] */
            ii(0x100d_b928, 6); mov(memd[ss, ebp - 0x104], eax);        /* mov [ebp-0x104], eax */
        l_0x100d_b92e:
            ii(0x100d_b92e, 6); mov(eax, memd[ss, ebp - 0x104]);        /* mov eax, [ebp-0x104] */
            ii(0x100d_b934, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b937, 6); mov(memd[ds, edx + 0x36d], eax);        /* mov [edx+0x36d], eax */
            ii(0x100d_b93d, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_b941, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_b947, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x100d_b94d, 5); call(0x100c_b67c, -0x1_02d6);           /* call 0x100cb67c */
            ii(0x100d_b952, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_b954, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b957, 4); mov(memw[ds, eax + 0x4d], dx);          /* mov [eax+0x4d], dx */
            ii(0x100d_b95b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b95e, 4); mov(dx, memw[ds, eax + 0x4d]);          /* mov dx, [eax+0x4d] */
            ii(0x100d_b962, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b965, 4); mov(memw[ds, eax + 0x4f], dx);          /* mov [eax+0x4f], dx */
            ii(0x100d_b969, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100d_b96e, 3); mov(edi, memd[ss, ebp - 0xc]);          /* mov edi, [ebp-0xc] */
            ii(0x100d_b971, 3); lea(edi, edi + 0x31);                   /* lea edi, [edi+0x31] */
            ii(0x100d_b974, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x100d_b977, 3); lea(esi, esi + 0x17);                   /* lea esi, [esi+0x17] */
            ii(0x100d_b97a, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x100d_b97c, 2); movsw();                                /* movsw */
            ii(0x100d_b97e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b981, 7); mov(memd[ds, eax + 0x31], 0xb);         /* mov dword [eax+0x31], 0xb */
            ii(0x100d_b988, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b98b, 7); mov(memd[ds, eax + 0x35], 0xd);         /* mov dword [eax+0x35], 0xd */
            ii(0x100d_b992, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b995, 3); mov(edx, memd[ds, eax + 0x25]);         /* mov edx, [eax+0x25] */
            ii(0x100d_b998, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_b99b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b99e, 3); mov(ebx, memd[ds, eax + 0x35]);         /* mov ebx, [eax+0x35] */
            ii(0x100d_b9a1, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x100d_b9a4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b9a7, 3); mov(edx, memd[ds, eax + 0x2d]);         /* mov edx, [eax+0x2d] */
            ii(0x100d_b9aa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b9ad, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_b9b0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_b9b2, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b9b5, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100d_b9b7, 3); mov(memd[ds, edx + 0x47], ebx);         /* mov [edx+0x47], ebx */
            ii(0x100d_b9ba, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b9bd, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_b9c0, 5); add(eax, 0x118);                        /* add eax, 0x118 */
            ii(0x100d_b9c5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b9c8, 3); mov(memd[ds, edx + 0x39], eax);         /* mov [edx+0x39], eax */
            ii(0x100d_b9cb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b9ce, 3); mov(eax, memd[ds, eax + 0x35]);         /* mov eax, [eax+0x35] */
            ii(0x100d_b9d1, 5); add(eax, 0xf0);                         /* add eax, 0xf0 */
            ii(0x100d_b9d6, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_b9d9, 3); mov(memd[ds, edx + 0x3d], eax);         /* mov [edx+0x3d], eax */
            ii(0x100d_b9dc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_b9df, 10); mov(memd[ds, eax + 0x345], 0);         /* mov dword [eax+0x345], 0x0 */
            ii(0x100d_b9e9, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100d_b9ee, 6); lea(edi, ebp - 0x120);                  /* lea edi, [ebp-0x120] */
            ii(0x100d_b9f4, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x100d_b9f7, 3); lea(esi, esi + 0x17);                   /* lea esi, [esi+0x17] */
            ii(0x100d_b9fa, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x100d_b9fc, 2); movsw();                                /* movsw */
            ii(0x100d_b9fe, 10); mov(memd[ss, ebp - 0x120], 0x1e2);     /* mov dword [ebp-0x120], 0x1e2 */
            ii(0x100d_ba08, 10); mov(memd[ss, ebp - 0x11c], 0x50);      /* mov dword [ebp-0x11c], 0x50 */
            ii(0x100d_ba12, 10); mov(memd[ss, ebp - 0x118], 0x271);     /* mov dword [ebp-0x118], 0x271 */
            ii(0x100d_ba1c, 10); mov(memd[ss, ebp - 0x114], 0x172);     /* mov dword [ebp-0x114], 0x172 */
            ii(0x100d_ba26, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_ba29, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x100d_ba2c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_ba2f, 6); mov(edx, memd[ss, ebp - 0x11c]);        /* mov edx, [ebp-0x11c] */
            ii(0x100d_ba35, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_ba38, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_ba3b, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_ba3e, 6); add(eax, memd[ss, ebp - 0x120]);        /* add eax, [ebp-0x120] */
            ii(0x100d_ba44, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_ba46, 6); mov(memd[ss, ebp - 0x10a], eax);        /* mov [ebp-0x10a], eax */
            ii(0x100d_ba4c, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_ba51, 5); call(/* sys */ 0x1016_a24c, 0x8_e7f6);  /* call 0x1016a24c */
            ii(0x100d_ba56, 5); call(0x100d_531c, -0x673f);             /* call 0x100d531c */
            ii(0x100d_ba5b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_ba60, 1); push(eax);                              /* push eax */
            ii(0x100d_ba61, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_ba66, 1); push(eax);                              /* push eax */
            ii(0x100d_ba67, 2); push(0x2);                              /* push 0x2 */
            ii(0x100d_ba69, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x100d_ba6e, 1); push(eax);                              /* push eax */
            ii(0x100d_ba6f, 5); mov(eax, 0x9e);                         /* mov eax, 0x9e */
            ii(0x100d_ba74, 1); push(eax);                              /* push eax */
            ii(0x100d_ba75, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x100d_ba7a, 1); push(eax);                              /* push eax */
            ii(0x100d_ba7b, 5); mov(ecx, 0x147);                        /* mov ecx, 0x147 */
            ii(0x100d_ba80, 5); mov(ebx, StringDefinitions.UpgradesMenu); /* mov ebx, 0x101a19eb */
            ii(0x100d_ba85, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_ba88, 3); mov(edx, memd[ds, edx + 0x25]);         /* mov edx, [edx+0x25] */
            ii(0x100d_ba8b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_ba8e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_ba91, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_ba94, 5); call(0x100e_9ae5, 0xe04c);              /* call 0x100e9ae5 */
            ii(0x100d_ba99, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_ba9e, 6); lea(eax, ebp - 0x124);                  /* lea eax, [ebp-0x124] */
            ii(0x100d_baa4, 5); call(0x100d_4d78, -0x6d31);             /* call 0x100d4d78 */
            ii(0x100d_baa9, 1); push(eax);                              /* push eax */
            ii(0x100d_baaa, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_baaf, 1); push(eax);                              /* push eax */
            ii(0x100d_bab0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_bab5, 1); push(eax);                              /* push eax */
            ii(0x100d_bab6, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_babb, 1); push(eax);                              /* push eax */
            ii(0x100d_babc, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x100d_bac1, 1); push(eax);                              /* push eax */
            ii(0x100d_bac2, 5); mov(ecx, 0x108);                        /* mov ecx, 0x108 */
            ii(0x100d_bac7, 5); mov(ebx, 0xd1);                         /* mov ebx, 0xd1 */
            ii(0x100d_bacc, 5); mov(edx, StringDefinitions.Description5); /* mov edx, 0x101a19f9 */
            ii(0x100d_bad1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bad4, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_bad7, 5); call(0x100e_ab9d, 0xf0c1);              /* call 0x100eab9d */
            ii(0x100d_badc, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_bae1, 6); lea(eax, ebp - 0x128);                  /* lea eax, [ebp-0x128] */
            ii(0x100d_bae7, 5); call(0x100d_4d78, -0x6d74);             /* call 0x100d4d78 */
            ii(0x100d_baec, 1); push(eax);                              /* push eax */
            ii(0x100d_baed, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_baf2, 1); push(eax);                              /* push eax */
            ii(0x100d_baf3, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_baf8, 1); push(eax);                              /* push eax */
            ii(0x100d_baf9, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x100d_bafe, 1); push(eax);                              /* push eax */
            ii(0x100d_baff, 5); mov(eax, 0x30);                         /* mov eax, 0x30 */
            ii(0x100d_bb04, 1); push(eax);                              /* push eax */
            ii(0x100d_bb05, 5); mov(ecx, 0x11b);                        /* mov ecx, 0x11b */
            ii(0x100d_bb0a, 5); mov(ebx, 0x140);                        /* mov ebx, 0x140 */
            ii(0x100d_bb0f, 5); mov(edx, StringDefinitions.Cost8);      /* mov edx, 0x101a1a05 */
            ii(0x100d_bb14, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bb17, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_bb1a, 5); call(0x100e_ab9d, 0xf07e);              /* call 0x100eab9d */
            ii(0x100d_bb1f, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_bb24, 6); lea(eax, ebp - 0x12c);                  /* lea eax, [ebp-0x12c] */
            ii(0x100d_bb2a, 5); call(0x100d_4d78, -0x6db7);             /* call 0x100d4d78 */
            ii(0x100d_bb2f, 1); push(eax);                              /* push eax */
            ii(0x100d_bb30, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_bb35, 1); push(eax);                              /* push eax */
            ii(0x100d_bb36, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_bb3b, 1); push(eax);                              /* push eax */
            ii(0x100d_bb3c, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_bb41, 1); push(eax);                              /* push eax */
            ii(0x100d_bb42, 5); mov(eax, 0x30);                         /* mov eax, 0x30 */
            ii(0x100d_bb47, 1); push(eax);                              /* push eax */
            ii(0x100d_bb48, 5); mov(ecx, 0x11c);                        /* mov ecx, 0x11c */
            ii(0x100d_bb4d, 5); mov(ebx, 0x166);                        /* mov ebx, 0x166 */
            ii(0x100d_bb52, 5); mov(edx, StringDefinitions.Credit2);    /* mov edx, 0x101a1a0a */
            ii(0x100d_bb57, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bb5a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_bb5d, 5); call(0x100e_ab9d, 0xf03b);              /* call 0x100eab9d */
            ii(0x100d_bb62, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bb65, 5); call(0x100d_9269, -0x2901);             /* call 0x100d9269 */
            ii(0x100d_bb6a, 5); mov(eax, 0x44);                         /* mov eax, 0x44 */
            ii(0x100d_bb6f, 5); call(Definitions.sys_new, 0x8_a28c);    /* call 0x10165e00 */
            ii(0x100d_bb74, 6); mov(memd[ss, ebp - 0x130], eax);        /* mov [ebp-0x130], eax */
            ii(0x100d_bb7a, 6); mov(eax, memd[ss, ebp - 0x130]);        /* mov eax, [ebp-0x130] */
            ii(0x100d_bb80, 6); mov(memd[ss, ebp - 0x134], eax);        /* mov [ebp-0x134], eax */
            ii(0x100d_bb86, 7); cmp(memd[ss, ebp - 0x134], 0);          /* cmp dword [ebp-0x134], 0x0 */
            ii(0x100d_bb8d, 2); if(jz(0x100d_bbee, 0x5f)) goto l_0x100d_bbee; /* jz 0x100dbbee */
            ii(0x100d_bb8f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bb92, 6); push(memd[ds, eax + 0x34d]);            /* push dword [eax+0x34d] */
            ii(0x100d_bb98, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bb9b, 6); push(memd[ds, eax + 0x349]);            /* push dword [eax+0x349] */
            ii(0x100d_bba1, 5); mov(eax, 0x7d0);                        /* mov eax, 0x7d0 */
            ii(0x100d_bba6, 1); push(eax);                              /* push eax */
            ii(0x100d_bba7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bbaa, 3); mov(eax, memd[ds, eax + 0x49]);         /* mov eax, [eax+0x49] */
            ii(0x100d_bbad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_bbb0, 1); push(eax);                              /* push eax */
            ii(0x100d_bbb1, 5); call(0x1008_b3ec, -0x5_07ca);           /* call 0x1008b3ec */
            ii(0x100d_bbb6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_bbb9, 6); lea(eax, ebp - 0x138);                  /* lea eax, [ebp-0x138] */
            ii(0x100d_bbbf, 5); call(0x1008_b1e4, -0x5_09e0);           /* call 0x1008b1e4 */
            ii(0x100d_bbc4, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100d_bbc6, 6); lea(ebx, ebp - 0x120);                  /* lea ebx, [ebp-0x120] */
            ii(0x100d_bbcc, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_bbcf, 6); mov(eax, memd[ss, ebp - 0x130]);        /* mov eax, [ebp-0x130] */
            ii(0x100d_bbd5, 5); call(0x100c_fe4d, -0xbd8d);             /* call 0x100cfe4d */
            ii(0x100d_bbda, 6); mov(memd[ss, ebp - 0x13c], eax);        /* mov [ebp-0x13c], eax */
            ii(0x100d_bbe0, 6); mov(eax, memd[ss, ebp - 0x13c]);        /* mov eax, [ebp-0x13c] */
            ii(0x100d_bbe6, 6); mov(memd[ss, ebp - 0x140], eax);        /* mov [ebp-0x140], eax */
            ii(0x100d_bbec, 2); jmp(0x100d_bbfa, 0xc); goto l_0x100d_bbfa; /* jmp 0x100dbbfa */
        l_0x100d_bbee:
            ii(0x100d_bbee, 6); mov(eax, memd[ss, ebp - 0x134]);        /* mov eax, [ebp-0x134] */
            ii(0x100d_bbf4, 6); mov(memd[ss, ebp - 0x140], eax);        /* mov [ebp-0x140], eax */
        l_0x100d_bbfa:
            ii(0x100d_bbfa, 6); mov(eax, memd[ss, ebp - 0x140]);        /* mov eax, [ebp-0x140] */
            ii(0x100d_bc00, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_bc03, 6); mov(memd[ds, edx + 0x345], eax);        /* mov [edx+0x345], eax */
            ii(0x100d_bc09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_bc0b, 6); lea(eax, ebp - 0x138);                  /* lea eax, [ebp-0x138] */
            ii(0x100d_bc11, 5); call(0x1008_8b04, -0x5_3112);           /* call 0x10088b04 */
            ii(0x100d_bc16, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bc19, 6); mov(memd[ss, ebp - 0x144], eax);        /* mov [ebp-0x144], eax */
            ii(0x100d_bc1f, 6); mov(eax, memd[ss, ebp - 0x144]);        /* mov eax, [ebp-0x144] */
            ii(0x100d_bc25, 3); mov(edx, memd[ds, eax + 0x13]);         /* mov edx, [eax+0x13] */
            ii(0x100d_bc28, 6); mov(eax, memd[ss, ebp - 0x144]);        /* mov eax, [ebp-0x144] */
            ii(0x100d_bc2e, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x100d_bc31, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bc34, 6); mov(memd[ss, ebp - 0x148], eax);        /* mov [ebp-0x148], eax */
            ii(0x100d_bc3a, 6); mov(eax, memd[ss, ebp - 0x148]);        /* mov eax, [ebp-0x148] */
            ii(0x100d_bc40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_bc42, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_bc43, 1); pop(edi);                               /* pop edi */
            ii(0x100d_bc44, 1); pop(esi);                               /* pop esi */
            ii(0x100d_bc45, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_bc46, 1); ret();                                  /* ret */
        }
    }
}
