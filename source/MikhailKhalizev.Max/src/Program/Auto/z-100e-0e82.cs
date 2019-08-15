using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a9cbf15-f0d4-413f-a966-7901cfa3a5fc")]
        public void Method_100e_0e82()
        {
            ii(0x100e_0e82, 5); pushd(0x100);                           /* push 0x100 */
            ii(0x100e_0e87, 5); calld(Definitions.sys_check_available_stack_size, 0x8_4ec6); /* call 0x10165d52 */
            ii(0x100e_0e8c, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0e8d, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0e8e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0e8f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0e91, 6); sub(esp, 0xe4);                         /* sub esp, 0xe4 */
            ii(0x100e_0e97, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_0e9a, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_0e9d, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_0ea0, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100e_0ea3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_0ea6, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_0ea9, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x6_a7be); /* call 0x100766f0 */
            ii(0x100e_0eae, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x100e_0eb1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_0eb4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_0eb7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_0eba, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_0ebd, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_0ec0, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x100e_0ec2, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_0ec5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_0ec8, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_0eca, 5); calld(0x100d_6a11, -0xa4be);            /* call 0x100d6a11 */
            ii(0x100e_0ecf, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100e_0ed4, 5); calld(Definitions.sys_new, 0x8_4f27);   /* call 0x10165e00 */
            ii(0x100e_0ed9, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_0edc, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_0edf, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_0ee2, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100e_0ee6, 2); if(jzd(0x100e_0f1f, 0x37)) goto l_0x100e_0f1f; /* jz 0x100e0f1f */
            ii(0x100e_0ee8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0eeb, 5); calld(0x100e_4304, 0x3414);             /* call 0x100e4304 */
            ii(0x100e_0ef0, 1); cwde();                                 /* cwde */
            ii(0x100e_0ef1, 1); pushd(eax);                             /* push eax */
            ii(0x100e_0ef2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0ef5, 5); calld(0x100e_433c, 0x3442);             /* call 0x100e433c */
            ii(0x100e_0efa, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_0efd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0f00, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100e_0f03, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_0f06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0f09, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100e_0f0c, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100e_0f0f, 5); calld(0x100d_7bdc, -0x9338);            /* call 0x100d7bdc */
            ii(0x100e_0f14, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100e_0f17, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_0f1a, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100e_0f1d, 2); jmpd(0x100e_0f25, 0x6); goto l_0x100e_0f25; /* jmp 0x100e0f25 */
        l_0x100e_0f1f:
            ii(0x100e_0f1f, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_0f22, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100e_0f25:
            ii(0x100e_0f25, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100e_0f28, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_0f2b, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
            ii(0x100e_0f2e, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_0f31, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_0f34, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_0f37, 5); calld(0x100d_7d74, -0x91c8);            /* call 0x100d7d74 */
            ii(0x100e_0f3c, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100e_0f41, 5); calld(Definitions.sys_new, 0x8_4eba);   /* call 0x10165e00 */
            ii(0x100e_0f46, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100e_0f49, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100e_0f4c, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100e_0f4f, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100e_0f53, 2); if(jzd(0x100e_0f8c, 0x37)) goto l_0x100e_0f8c; /* jz 0x100e0f8c */
            ii(0x100e_0f55, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0f58, 5); calld(0x100e_4304, 0x33a7);             /* call 0x100e4304 */
            ii(0x100e_0f5d, 1); cwde();                                 /* cwde */
            ii(0x100e_0f5e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_0f5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0f62, 5); calld(0x100e_433c, 0x33d5);             /* call 0x100e433c */
            ii(0x100e_0f67, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_0f6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0f6d, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100e_0f70, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_0f73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0f76, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100e_0f79, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100e_0f7c, 5); calld(0x100d_7bdc, -0x93a5);            /* call 0x100d7bdc */
            ii(0x100e_0f81, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100e_0f84, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100e_0f87, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100e_0f8a, 2); jmpd(0x100e_0f92, 0x6); goto l_0x100e_0f92; /* jmp 0x100e0f92 */
        l_0x100e_0f8c:
            ii(0x100e_0f8c, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100e_0f8f, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
        l_0x100e_0f92:
            ii(0x100e_0f92, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100e_0f95, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_0f98, 3); mov(memd_a32[ds, edx + 0xc], eax);      /* mov [edx+0xc], eax */
            ii(0x100e_0f9b, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100e_0f9e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_0fa1, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_0fa4, 5); calld(0x100d_7d74, -0x9235);            /* call 0x100d7d74 */
            ii(0x100e_0fa9, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x100e_0fae, 1); pushd(eax);                             /* push eax */
            ii(0x100e_0faf, 5); mov(ecx, 0x46);                         /* mov ecx, 0x46 */
            ii(0x100e_0fb4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_0fb6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_0fb8, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100e_0fbb, 5); calld(0x1008_b148, -0x5_5e78);          /* call 0x1008b148 */
            ii(0x100e_0fc0, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100e_0fc5, 5); calld(/* sys */ 0x1016_a24c, 0x8_9282); /* call 0x1016a24c */
            ii(0x100e_0fca, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_0fcf, 5); calld(Definitions.sys_new, 0x8_4e2c);   /* call 0x10165e00 */
            ii(0x100e_0fd4, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100e_0fd7, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x100e_0fda, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100e_0fdd, 4); cmp(memd_a32[ss, ebp - 0x68], 0);       /* cmp dword [ebp-0x68], 0x0 */
            ii(0x100e_0fe1, 2); if(jzd(0x100e_101a, 0x37)) goto l_0x100e_101a; /* jz 0x100e101a */
            ii(0x100e_0fe3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0fe6, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100e_0fea, 5); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100e_0fef, 1); cwde();                                 /* cwde */
            ii(0x100e_0ff0, 1); pushd(eax);                             /* push eax */
            ii(0x100e_0ff1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0ff4, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_0ff7, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x100e_0ffa, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_0ffd, 5); mov(ebx, 0x18f);                        /* mov ebx, 0x18f */
            ii(0x100e_1002, 5); mov(edx, 0x18e);                        /* mov edx, 0x18e */
            ii(0x100e_1007, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x100e_100a, 5); calld(Definitions.my_ctor_c17, -0x1_2c00); /* call 0x100ce40f */
            ii(0x100e_100f, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100e_1012, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100e_1015, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100e_1018, 2); jmpd(0x100e_1020, 0x6); goto l_0x100e_1020; /* jmp 0x100e1020 */
        l_0x100e_101a:
            ii(0x100e_101a, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100e_101d, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
        l_0x100e_1020:
            ii(0x100e_1020, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x100e_1023, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_1026, 3); mov(memd_a32[ds, edx + 0x10], eax);     /* mov [edx+0x10], eax */
            ii(0x100e_1029, 5); mov(edx, 0x18f);                        /* mov edx, 0x18f */
            ii(0x100e_102e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_1031, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100e_1034, 5); calld(0x100c_f2ba, -0x1_1d7f);          /* call 0x100cf2ba */
            ii(0x100e_1039, 3); mov(edx, memd_a32[ss, ebp - 0x1e]);     /* mov edx, [ebp-0x1e] */
            ii(0x100e_103c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_103f, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100e_1042, 5); calld(0x100c_e92d, -0x1_271a);          /* call 0x100ce92d */
            ii(0x100e_1047, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x100e_104a, 5); calld(0x100e_0ba4, -0x4ab);             /* call 0x100e0ba4 */
            ii(0x100e_104f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1050, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x100e_1053, 5); calld(0x100e_0bd0, -0x488);             /* call 0x100e0bd0 */
            ii(0x100e_1058, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1059, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x100e_105c, 5); calld(0x100e_0bfc, -0x465);             /* call 0x100e0bfc */
            ii(0x100e_1061, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1062, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x100e_1065, 5); calld(0x100e_0c28, -0x442);             /* call 0x100e0c28 */
            ii(0x100e_106a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_106c, 3); lea(ebx, ebp - 0x60);                   /* lea ebx, [ebp-0x60] */
            ii(0x100e_106f, 5); mov(edx, StringDefinitions.Activate);   /* mov edx, 0x101a1b70 */
            ii(0x100e_1074, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_1077, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100e_107a, 5); calld(0x100c_edcd, -0x1_22b2);          /* call 0x100cedcd */
            ii(0x100e_107f, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100e_1082, 5); mov(edx, 0x100e_1c98);                  /* mov edx, 0x100e1c98 */
            ii(0x100e_1087, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_108a, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100e_108d, 5); calld(0x100c_f824, -0x1_186e);          /* call 0x100cf824 */
            ii(0x100e_1092, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_1097, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_109a, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100e_109d, 5); calld(0x100d_50d4, -0xbfce);            /* call 0x100d50d4 */
            ii(0x100e_10a2, 4); cmp(memb_a32[ss, ebp + 0x10], 0);       /* cmp byte [ebp+0x10], 0x0 */
            ii(0x100e_10a6, 6); if(jzd(0x100e_13c5, 0x319)) goto l_0x100e_13c5; /* jz 0x100e13c5 */
            ii(0x100e_10ac, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_10b1, 5); calld(Definitions.sys_new, 0x8_4d4a);   /* call 0x10165e00 */
            ii(0x100e_10b6, 6); mov(memd_a32[ss, ebp - 0x84], eax);     /* mov [ebp-0x84], eax */
            ii(0x100e_10bc, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100e_10c2, 6); mov(memd_a32[ss, ebp - 0x88], eax);     /* mov [ebp-0x88], eax */
            ii(0x100e_10c8, 7); cmp(memd_a32[ss, ebp - 0x88], 0);       /* cmp dword [ebp-0x88], 0x0 */
            ii(0x100e_10cf, 2); if(jzd(0x100e_1114, 0x43)) goto l_0x100e_1114; /* jz 0x100e1114 */
            ii(0x100e_10d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_10d4, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100e_10d8, 5); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100e_10dd, 1); cwde();                                 /* cwde */
            ii(0x100e_10de, 1); pushd(eax);                             /* push eax */
            ii(0x100e_10df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_10e2, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_10e5, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x100e_10e8, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_10eb, 5); mov(ebx, 0x18f);                        /* mov ebx, 0x18f */
            ii(0x100e_10f0, 5); mov(edx, 0x18e);                        /* mov edx, 0x18e */
            ii(0x100e_10f5, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100e_10fb, 5); calld(Definitions.my_ctor_c17, -0x1_2cf1); /* call 0x100ce40f */
            ii(0x100e_1100, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
            ii(0x100e_1106, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x100e_110c, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
            ii(0x100e_1112, 2); jmpd(0x100e_1120, 0xc); goto l_0x100e_1120; /* jmp 0x100e1120 */
        l_0x100e_1114:
            ii(0x100e_1114, 6); mov(eax, memd_a32[ss, ebp - 0x88]);     /* mov eax, [ebp-0x88] */
            ii(0x100e_111a, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
        l_0x100e_1120:
            ii(0x100e_1120, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100e_1126, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_1129, 3); mov(memd_a32[ds, edx + 0x14], eax);     /* mov [edx+0x14], eax */
            ii(0x100e_112c, 5); mov(edx, 0x18f);                        /* mov edx, 0x18f */
            ii(0x100e_1131, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_1134, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_1137, 5); calld(0x100c_f2ba, -0x1_1e82);          /* call 0x100cf2ba */
            ii(0x100e_113c, 3); mov(edx, memd_a32[ss, ebp - 0x1e]);     /* mov edx, [ebp-0x1e] */
            ii(0x100e_113f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_1142, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_1145, 5); calld(0x100c_e92d, -0x1_281d);          /* call 0x100ce92d */
            ii(0x100e_114a, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x100e_1150, 5); calld(0x100e_0ba4, -0x5b1);             /* call 0x100e0ba4 */
            ii(0x100e_1155, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1156, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x100e_115c, 5); calld(0x100e_0bd0, -0x591);             /* call 0x100e0bd0 */
            ii(0x100e_1161, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1162, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x100e_1168, 5); calld(0x100e_0bfc, -0x571);             /* call 0x100e0bfc */
            ii(0x100e_116d, 1); pushd(eax);                             /* push eax */
            ii(0x100e_116e, 6); lea(eax, ebp - 0xa0);                   /* lea eax, [ebp-0xa0] */
            ii(0x100e_1174, 5); calld(0x100e_0c28, -0x551);             /* call 0x100e0c28 */
            ii(0x100e_1179, 3); lea(ebx, ebp - 0x60);                   /* lea ebx, [ebp-0x60] */
            ii(0x100e_117c, 5); mov(edx, StringDefinitions.Reload);     /* mov edx, 0x101a1b79 */
            ii(0x100e_1181, 3); mov(esi, memd_a32[ss, ebp - 0x10]);     /* mov esi, [ebp-0x10] */
            ii(0x100e_1184, 3); mov(esi, memd_a32[ds, esi + 0x14]);     /* mov esi, [esi+0x14] */
            ii(0x100e_1187, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_1189, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100e_118b, 5); calld(0x100c_edcd, -0x1_23c3);          /* call 0x100cedcd */
            ii(0x100e_1190, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100e_1193, 5); mov(edx, 0x100e_1ceb);                  /* mov edx, 0x100e1ceb */
            ii(0x100e_1198, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_119b, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_119e, 5); calld(0x100c_f824, -0x1_197f);          /* call 0x100cf824 */
            ii(0x100e_11a3, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_11a8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_11ab, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100e_11ae, 5); calld(0x100d_50d4, -0xc0df);            /* call 0x100d50d4 */
            ii(0x100e_11b3, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_11b8, 5); calld(Definitions.sys_new, 0x8_4c43);   /* call 0x10165e00 */
            ii(0x100e_11bd, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100e_11c3, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100e_11c9, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100e_11cf, 7); cmp(memd_a32[ss, ebp - 0xa8], 0);       /* cmp dword [ebp-0xa8], 0x0 */
            ii(0x100e_11d6, 2); if(jzd(0x100e_121d, 0x45)) goto l_0x100e_121d; /* jz 0x100e121d */
            ii(0x100e_11d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_11db, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100e_11df, 5); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100e_11e4, 1); cwde();                                 /* cwde */
            ii(0x100e_11e5, 1); pushd(eax);                             /* push eax */
            ii(0x100e_11e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_11e9, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_11ec, 5); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_11f1, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_11f4, 5); mov(ebx, 0x18f);                        /* mov ebx, 0x18f */
            ii(0x100e_11f9, 5); mov(edx, 0x18e);                        /* mov edx, 0x18e */
            ii(0x100e_11fe, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100e_1204, 5); calld(Definitions.my_ctor_c17, -0x1_2dfa); /* call 0x100ce40f */
            ii(0x100e_1209, 6); mov(memd_a32[ss, ebp - 0xac], eax);     /* mov [ebp-0xac], eax */
            ii(0x100e_120f, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100e_1215, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
            ii(0x100e_121b, 2); jmpd(0x100e_1229, 0xc); goto l_0x100e_1229; /* jmp 0x100e1229 */
        l_0x100e_121d:
            ii(0x100e_121d, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100e_1223, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
        l_0x100e_1229:
            ii(0x100e_1229, 6); mov(eax, memd_a32[ss, ebp - 0xb0]);     /* mov eax, [ebp-0xb0] */
            ii(0x100e_122f, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_1232, 3); mov(memd_a32[ds, edx + 0x18], eax);     /* mov [edx+0x18], eax */
            ii(0x100e_1235, 5); mov(edx, 0x18f);                        /* mov edx, 0x18f */
            ii(0x100e_123a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_123d, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100e_1240, 5); calld(0x100c_f2ba, -0x1_1f8b);          /* call 0x100cf2ba */
            ii(0x100e_1245, 3); mov(edx, memd_a32[ss, ebp - 0x1e]);     /* mov edx, [ebp-0x1e] */
            ii(0x100e_1248, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_124b, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100e_124e, 5); calld(0x100c_e92d, -0x1_2926);          /* call 0x100ce92d */
            ii(0x100e_1253, 6); lea(eax, ebp - 0xb4);                   /* lea eax, [ebp-0xb4] */
            ii(0x100e_1259, 5); calld(0x100e_0ba4, -0x6ba);             /* call 0x100e0ba4 */
            ii(0x100e_125e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_125f, 6); lea(eax, ebp - 0xb8);                   /* lea eax, [ebp-0xb8] */
            ii(0x100e_1265, 5); calld(0x100e_0bd0, -0x69a);             /* call 0x100e0bd0 */
            ii(0x100e_126a, 1); pushd(eax);                             /* push eax */
            ii(0x100e_126b, 6); lea(eax, ebp - 0xbc);                   /* lea eax, [ebp-0xbc] */
            ii(0x100e_1271, 5); calld(0x100e_0bfc, -0x67a);             /* call 0x100e0bfc */
            ii(0x100e_1276, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1277, 6); lea(eax, ebp - 0xc0);                   /* lea eax, [ebp-0xc0] */
            ii(0x100e_127d, 5); calld(0x100e_0c28, -0x65a);             /* call 0x100e0c28 */
            ii(0x100e_1282, 3); lea(ebx, ebp - 0x60);                   /* lea ebx, [ebp-0x60] */
            ii(0x100e_1285, 5); mov(edx, StringDefinitions.Repair2);    /* mov edx, 0x101a1b80 */
            ii(0x100e_128a, 3); mov(esi, memd_a32[ss, ebp - 0x10]);     /* mov esi, [ebp-0x10] */
            ii(0x100e_128d, 3); mov(esi, memd_a32[ds, esi + 0x18]);     /* mov esi, [esi+0x18] */
            ii(0x100e_1290, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_1292, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100e_1294, 5); calld(0x100c_edcd, -0x1_24cc);          /* call 0x100cedcd */
            ii(0x100e_1299, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100e_129c, 5); mov(edx, 0x100e_1da5);                  /* mov edx, 0x100e1da5 */
            ii(0x100e_12a1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_12a4, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100e_12a7, 5); calld(0x100c_f824, -0x1_1a88);          /* call 0x100cf824 */
            ii(0x100e_12ac, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_12b1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_12b4, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100e_12b7, 5); calld(0x100d_50d4, -0xc1e8);            /* call 0x100d50d4 */
            ii(0x100e_12bc, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100e_12c1, 5); calld(Definitions.sys_new, 0x8_4b3a);   /* call 0x10165e00 */
            ii(0x100e_12c6, 6); mov(memd_a32[ss, ebp - 0xc4], eax);     /* mov [ebp-0xc4], eax */
            ii(0x100e_12cc, 6); mov(eax, memd_a32[ss, ebp - 0xc4]);     /* mov eax, [ebp-0xc4] */
            ii(0x100e_12d2, 6); mov(memd_a32[ss, ebp - 0xc8], eax);     /* mov [ebp-0xc8], eax */
            ii(0x100e_12d8, 7); cmp(memd_a32[ss, ebp - 0xc8], 0);       /* cmp dword [ebp-0xc8], 0x0 */
            ii(0x100e_12df, 2); if(jzd(0x100e_1326, 0x45)) goto l_0x100e_1326; /* jz 0x100e1326 */
            ii(0x100e_12e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_12e4, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100e_12e8, 5); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100e_12ed, 1); cwde();                                 /* cwde */
            ii(0x100e_12ee, 1); pushd(eax);                             /* push eax */
            ii(0x100e_12ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_12f2, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_12f5, 5); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_12fa, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_12fd, 5); mov(ebx, 0x18f);                        /* mov ebx, 0x18f */
            ii(0x100e_1302, 5); mov(edx, 0x18e);                        /* mov edx, 0x18e */
            ii(0x100e_1307, 6); mov(eax, memd_a32[ss, ebp - 0xc4]);     /* mov eax, [ebp-0xc4] */
            ii(0x100e_130d, 5); calld(Definitions.my_ctor_c17, -0x1_2f03); /* call 0x100ce40f */
            ii(0x100e_1312, 6); mov(memd_a32[ss, ebp - 0xcc], eax);     /* mov [ebp-0xcc], eax */
            ii(0x100e_1318, 6); mov(eax, memd_a32[ss, ebp - 0xcc]);     /* mov eax, [ebp-0xcc] */
            ii(0x100e_131e, 6); mov(memd_a32[ss, ebp - 0xd0], eax);     /* mov [ebp-0xd0], eax */
            ii(0x100e_1324, 2); jmpd(0x100e_1332, 0xc); goto l_0x100e_1332; /* jmp 0x100e1332 */
        l_0x100e_1326:
            ii(0x100e_1326, 6); mov(eax, memd_a32[ss, ebp - 0xc8]);     /* mov eax, [ebp-0xc8] */
            ii(0x100e_132c, 6); mov(memd_a32[ss, ebp - 0xd0], eax);     /* mov [ebp-0xd0], eax */
        l_0x100e_1332:
            ii(0x100e_1332, 6); mov(eax, memd_a32[ss, ebp - 0xd0]);     /* mov eax, [ebp-0xd0] */
            ii(0x100e_1338, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_133b, 3); mov(memd_a32[ds, edx + 0x1c], eax);     /* mov [edx+0x1c], eax */
            ii(0x100e_133e, 5); mov(edx, 0x18f);                        /* mov edx, 0x18f */
            ii(0x100e_1343, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_1346, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100e_1349, 5); calld(0x100c_f2ba, -0x1_2094);          /* call 0x100cf2ba */
            ii(0x100e_134e, 3); mov(edx, memd_a32[ss, ebp - 0x1e]);     /* mov edx, [ebp-0x1e] */
            ii(0x100e_1351, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_1354, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100e_1357, 5); calld(0x100c_e92d, -0x1_2a2f);          /* call 0x100ce92d */
            ii(0x100e_135c, 6); lea(eax, ebp - 0xd4);                   /* lea eax, [ebp-0xd4] */
            ii(0x100e_1362, 5); calld(0x100e_0ba4, -0x7c3);             /* call 0x100e0ba4 */
            ii(0x100e_1367, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1368, 6); lea(eax, ebp - 0xd8);                   /* lea eax, [ebp-0xd8] */
            ii(0x100e_136e, 5); calld(0x100e_0bd0, -0x7a3);             /* call 0x100e0bd0 */
            ii(0x100e_1373, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1374, 6); lea(eax, ebp - 0xdc);                   /* lea eax, [ebp-0xdc] */
            ii(0x100e_137a, 5); calld(0x100e_0bfc, -0x783);             /* call 0x100e0bfc */
            ii(0x100e_137f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1380, 6); lea(eax, ebp - 0xe0);                   /* lea eax, [ebp-0xe0] */
            ii(0x100e_1386, 5); calld(0x100e_0c28, -0x763);             /* call 0x100e0c28 */
            ii(0x100e_138b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_138d, 3); lea(ebx, ebp - 0x60);                   /* lea ebx, [ebp-0x60] */
            ii(0x100e_1390, 5); mov(edx, StringDefinitions.Upgrade);    /* mov edx, 0x101a1b87 */
            ii(0x100e_1395, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_1398, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100e_139b, 5); calld(0x100c_edcd, -0x1_25d3);          /* call 0x100cedcd */
            ii(0x100e_13a0, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100e_13a3, 5); mov(edx, 0x100e_1e5f);                  /* mov edx, 0x100e1e5f */
            ii(0x100e_13a8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_13ab, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100e_13ae, 5); calld(0x100c_f824, -0x1_1b8f);          /* call 0x100cf824 */
            ii(0x100e_13b3, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x100e_13b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_13bb, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100e_13be, 5); calld(0x100d_50d4, -0xc2ef);            /* call 0x100d50d4 */
            ii(0x100e_13c3, 2); jmpd(0x100e_13e3, 0x1e); goto l_0x100e_13e3; /* jmp 0x100e13e3 */
        l_0x100e_13c5:
            ii(0x100e_13c5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_13c8, 7); mov(memd_a32[ds, eax + 0x14], 0);       /* mov dword [eax+0x14], 0x0 */
            ii(0x100e_13cf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_13d2, 7); mov(memd_a32[ds, eax + 0x18], 0);       /* mov dword [eax+0x18], 0x0 */
            ii(0x100e_13d9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_13dc, 7); mov(memd_a32[ds, eax + 0x1c], 0);       /* mov dword [eax+0x1c], 0x0 */
        l_0x100e_13e3:
            ii(0x100e_13e3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_13e6, 6); mov(memd_a32[ss, ebp - 0xe4], eax);     /* mov [ebp-0xe4], eax */
            ii(0x100e_13ec, 6); mov(eax, memd_a32[ss, ebp - 0xe4]);     /* mov eax, [ebp-0xe4] */
            ii(0x100e_13f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_13f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_13f5, 1); popd(edi);                              /* pop edi */
            ii(0x100e_13f6, 1); popd(esi);                              /* pop esi */
            ii(0x100e_13f7, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
