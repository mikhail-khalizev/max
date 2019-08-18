using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5504-c0b0f0c")]
        public void Method_100d_5504()
        {
            ii(0x100d_5504, 5); pushd(0xe4);                            /* push 0xe4 */
            ii(0x100d_5509, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0844); /* call 0x10165d52 */
            ii(0x100d_550e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_550f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_5510, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5511, 1); pushd(edi);                             /* push edi */
            ii(0x100d_5512, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_5513, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5515, 6); sub(esp, 0xb4);                         /* sub esp, 0xb4 */
            ii(0x100d_551b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_551e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_5521, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x100d_5526, 5); mov(edx, 0x6d1);                        /* mov edx, 0x6d1 */
            ii(0x100d_552b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_552e, 5); calld(0x100d_68a3, 0x1370);             /* call 0x100d68a3 */
            ii(0x100d_5533, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_5536, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_5539, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_553c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_553f, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_5d28); /* mov dword [eax+0x13], 0x101b5d28 */
            ii(0x100d_5546, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_554b, 5); calld(0x1012_0d94, 0x4_b844);           /* call 0x10120d94 */
            ii(0x100d_5550, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_5555, 5); calld(/* sys */ 0x1016_a24c, 0x9_4cf2); /* call 0x1016a24c */
            ii(0x100d_555a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_555d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_5560, 7); mov(memw_a32[ds, edx + 0x8e], ax);      /* mov [edx+0x8e], ax */
            ii(0x100d_5567, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_556a, 7); mov(memb_a32[ds, eax + 0x90], 0);       /* mov byte [eax+0x90], 0x0 */
            ii(0x100d_5571, 5); calld(0x100d_6124, 0xbae);              /* call 0x100d6124 */
            ii(0x100d_5576, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5578, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_557a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_557d, 5); calld(0x100d_6adf, 0x155d);             /* call 0x100d6adf */
            ii(0x100d_5582, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_5585, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_5588, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_558b, 5); calld(0x100d_6a11, 0x1481);             /* call 0x100d6a11 */
            ii(0x100d_5590, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_5595, 5); calld(Definitions.sys_new, 0x9_0866);   /* call 0x10165e00 */
            ii(0x100d_559a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_559d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_55a0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_55a3, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100d_55a7, 2); if(jzd(0x100d_55d1, 0x28)) goto l_0x100d_55d1; /* jz 0x100d55d1 */
            ii(0x100d_55a9, 5); mov(eax, 0x7d);                         /* mov eax, 0x7d */
            ii(0x100d_55ae, 1); pushd(eax);                             /* push eax */
            ii(0x100d_55af, 5); mov(ecx, 0x8b);                         /* mov ecx, 0x8b */
            ii(0x100d_55b4, 5); mov(ebx, 0x16d);                        /* mov ebx, 0x16d */
            ii(0x100d_55b9, 5); mov(edx, 0x16c);                        /* mov edx, 0x16c */
            ii(0x100d_55be, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_55c1, 5); calld(Definitions.my_ctor_c17, -0x71b7); /* call 0x100ce40f */
            ii(0x100d_55c6, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_55c9, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_55cc, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_55cf, 2); jmpd(0x100d_55d7, 0x6); goto l_0x100d_55d7; /* jmp 0x100d55d7 */
        l_0x100d_55d1:
            ii(0x100d_55d1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_55d4, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100d_55d7:
            ii(0x100d_55d7, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_55da, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_55dd, 3); mov(memd_a32[ds, edx + 0x32], eax);     /* mov [edx+0x32], eax */
            ii(0x100d_55e0, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_55e5, 5); calld(Definitions.sys_new, 0x9_0816);   /* call 0x10165e00 */
            ii(0x100d_55ea, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100d_55ed, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_55f0, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_55f3, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100d_55f7, 2); if(jzd(0x100d_5621, 0x28)) goto l_0x100d_5621; /* jz 0x100d5621 */
            ii(0x100d_55f9, 5); mov(eax, 0x7d);                         /* mov eax, 0x7d */
            ii(0x100d_55fe, 1); pushd(eax);                             /* push eax */
            ii(0x100d_55ff, 5); mov(ecx, 0xe5);                         /* mov ecx, 0xe5 */
            ii(0x100d_5604, 5); mov(ebx, 0x171);                        /* mov ebx, 0x171 */
            ii(0x100d_5609, 5); mov(edx, 0x170);                        /* mov edx, 0x170 */
            ii(0x100d_560e, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_5611, 5); calld(Definitions.my_ctor_c17, -0x7207); /* call 0x100ce40f */
            ii(0x100d_5616, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100d_5619, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100d_561c, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100d_561f, 2); jmpd(0x100d_5627, 0x6); goto l_0x100d_5627; /* jmp 0x100d5627 */
        l_0x100d_5621:
            ii(0x100d_5621, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100d_5624, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x100d_5627:
            ii(0x100d_5627, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_562a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_562d, 3); mov(memd_a32[ds, edx + 0x36], eax);     /* mov [edx+0x36], eax */
            ii(0x100d_5630, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_5635, 5); calld(Definitions.sys_new, 0x9_07c6);   /* call 0x10165e00 */
            ii(0x100d_563a, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100d_563d, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_5640, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100d_5643, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100d_5647, 2); if(jzd(0x100d_5671, 0x28)) goto l_0x100d_5671; /* jz 0x100d5671 */
            ii(0x100d_5649, 5); mov(eax, 0x7d);                         /* mov eax, 0x7d */
            ii(0x100d_564e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_564f, 5); mov(ecx, 0xca);                         /* mov ecx, 0xca */
            ii(0x100d_5654, 5); mov(ebx, 0x16f);                        /* mov ebx, 0x16f */
            ii(0x100d_5659, 5); mov(edx, 0x16e);                        /* mov edx, 0x16e */
            ii(0x100d_565e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_5661, 5); calld(Definitions.my_ctor_c17, -0x7257); /* call 0x100ce40f */
            ii(0x100d_5666, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100d_5669, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100d_566c, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100d_566f, 2); jmpd(0x100d_5677, 0x6); goto l_0x100d_5677; /* jmp 0x100d5677 */
        l_0x100d_5671:
            ii(0x100d_5671, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_5674, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100d_5677:
            ii(0x100d_5677, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100d_567a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_567d, 3); mov(memd_a32[ds, edx + 0x3a], eax);     /* mov [edx+0x3a], eax */
            ii(0x100d_5680, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_5685, 5); calld(Definitions.sys_new, 0x9_0776);   /* call 0x10165e00 */
            ii(0x100d_568a, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100d_568d, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100d_5690, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100d_5693, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100d_5697, 2); if(jzd(0x100d_56c1, 0x28)) goto l_0x100d_56c1; /* jz 0x100d56c1 */
            ii(0x100d_5699, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x100d_569e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_569f, 5); mov(ecx, 0x19);                         /* mov ecx, 0x19 */
            ii(0x100d_56a4, 5); mov(ebx, 0x173);                        /* mov ebx, 0x173 */
            ii(0x100d_56a9, 5); mov(edx, 0x172);                        /* mov edx, 0x172 */
            ii(0x100d_56ae, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100d_56b1, 5); calld(Definitions.my_ctor_c17, -0x72a7); /* call 0x100ce40f */
            ii(0x100d_56b6, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100d_56b9, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100d_56bc, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100d_56bf, 2); jmpd(0x100d_56c7, 0x6); goto l_0x100d_56c7; /* jmp 0x100d56c7 */
        l_0x100d_56c1:
            ii(0x100d_56c1, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100d_56c4, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
        l_0x100d_56c7:
            ii(0x100d_56c7, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100d_56ca, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_56cd, 3); mov(memd_a32[ds, edx + 0x3e], eax);     /* mov [edx+0x3e], eax */
            ii(0x100d_56d0, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_56d5, 5); calld(Definitions.sys_new, 0x9_0726);   /* call 0x10165e00 */
            ii(0x100d_56da, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100d_56dd, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_56e0, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100d_56e3, 4); cmp(memd_a32[ss, ebp - 0x58], 0);       /* cmp dword [ebp-0x58], 0x0 */
            ii(0x100d_56e7, 2); if(jzd(0x100d_5711, 0x28)) goto l_0x100d_5711; /* jz 0x100d5711 */
            ii(0x100d_56e9, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x100d_56ee, 1); pushd(eax);                             /* push eax */
            ii(0x100d_56ef, 5); mov(ecx, 0xde);                         /* mov ecx, 0xde */
            ii(0x100d_56f4, 5); mov(ebx, 0x175);                        /* mov ebx, 0x175 */
            ii(0x100d_56f9, 5); mov(edx, 0x174);                        /* mov edx, 0x174 */
            ii(0x100d_56fe, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100d_5701, 5); calld(Definitions.my_ctor_c17, -0x72f7); /* call 0x100ce40f */
            ii(0x100d_5706, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100d_5709, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x100d_570c, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x100d_570f, 2); jmpd(0x100d_5717, 0x6); goto l_0x100d_5717; /* jmp 0x100d5717 */
        l_0x100d_5711:
            ii(0x100d_5711, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100d_5714, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
        l_0x100d_5717:
            ii(0x100d_5717, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x100d_571a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_571d, 3); mov(memd_a32[ds, edx + 0x42], eax);     /* mov [edx+0x42], eax */
            ii(0x100d_5720, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_5725, 5); calld(Definitions.sys_new, 0x9_06d6);   /* call 0x10165e00 */
            ii(0x100d_572a, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100d_572d, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x100d_5730, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100d_5733, 4); cmp(memd_a32[ss, ebp - 0x68], 0);       /* cmp dword [ebp-0x68], 0x0 */
            ii(0x100d_5737, 2); if(jzd(0x100d_5761, 0x28)) goto l_0x100d_5761; /* jz 0x100d5761 */
            ii(0x100d_5739, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100d_573e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_573f, 5); mov(ecx, 0x19);                         /* mov ecx, 0x19 */
            ii(0x100d_5744, 5); mov(ebx, 0x177);                        /* mov ebx, 0x177 */
            ii(0x100d_5749, 5); mov(edx, 0x176);                        /* mov edx, 0x176 */
            ii(0x100d_574e, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x100d_5751, 5); calld(Definitions.my_ctor_c17, -0x7347); /* call 0x100ce40f */
            ii(0x100d_5756, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100d_5759, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100d_575c, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100d_575f, 2); jmpd(0x100d_5767, 0x6); goto l_0x100d_5767; /* jmp 0x100d5767 */
        l_0x100d_5761:
            ii(0x100d_5761, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100d_5764, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
        l_0x100d_5767:
            ii(0x100d_5767, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x100d_576a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_576d, 3); mov(memd_a32[ds, edx + 0x46], eax);     /* mov [edx+0x46], eax */
            ii(0x100d_5770, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_5775, 5); calld(Definitions.sys_new, 0x9_0686);   /* call 0x10165e00 */
            ii(0x100d_577a, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100d_577d, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x100d_5780, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100d_5783, 4); cmp(memd_a32[ss, ebp - 0x78], 0);       /* cmp dword [ebp-0x78], 0x0 */
            ii(0x100d_5787, 2); if(jzd(0x100d_57b1, 0x28)) goto l_0x100d_57b1; /* jz 0x100d57b1 */
            ii(0x100d_5789, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100d_578e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_578f, 5); mov(ecx, 0xde);                         /* mov ecx, 0xde */
            ii(0x100d_5794, 5); mov(ebx, 0x179);                        /* mov ebx, 0x179 */
            ii(0x100d_5799, 5); mov(edx, 0x178);                        /* mov edx, 0x178 */
            ii(0x100d_579e, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x100d_57a1, 5); calld(Definitions.my_ctor_c17, -0x7397); /* call 0x100ce40f */
            ii(0x100d_57a6, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100d_57a9, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100d_57ac, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100d_57af, 2); jmpd(0x100d_57b7, 0x6); goto l_0x100d_57b7; /* jmp 0x100d57b7 */
        l_0x100d_57b1:
            ii(0x100d_57b1, 3); mov(eax, memd_a32[ss, ebp - 0x78]);     /* mov eax, [ebp-0x78] */
            ii(0x100d_57b4, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
        l_0x100d_57b7:
            ii(0x100d_57b7, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100d_57ba, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_57bd, 3); mov(memd_a32[ds, edx + 0x4a], eax);     /* mov [edx+0x4a], eax */
            ii(0x100d_57c0, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x100d_57c6, 5); calld(0x100d_5224, -0x5a7);             /* call 0x100d5224 */
            ii(0x100d_57cb, 1); pushd(eax);                             /* push eax */
            ii(0x100d_57cc, 6); lea(eax, ebp - 0x88);                   /* lea eax, [ebp-0x88] */
            ii(0x100d_57d2, 5); calld(0x100d_5250, -0x587);             /* call 0x100d5250 */
            ii(0x100d_57d7, 1); pushd(eax);                             /* push eax */
            ii(0x100d_57d8, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x100d_57de, 5); calld(0x100d_527c, -0x567);             /* call 0x100d527c */
            ii(0x100d_57e3, 1); pushd(eax);                             /* push eax */
            ii(0x100d_57e4, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x100d_57ea, 5); calld(0x100d_52a8, -0x547);             /* call 0x100d52a8 */
            ii(0x100d_57ef, 1); pushd(eax);                             /* push eax */
            ii(0x100d_57f0, 5); calld(0x100d_52d4, -0x521);             /* call 0x100d52d4 */
            ii(0x100d_57f5, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_57f8, 5); calld(0x100d_52f8, -0x505);             /* call 0x100d52f8 */
            ii(0x100d_57fd, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_5800, 5); mov(edx, StringDefinitions.Send);       /* mov edx, 0x101a177c */
            ii(0x100d_5805, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5808, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x100d_580b, 5); calld(0x100c_ef64, -0x68ac);            /* call 0x100cef64 */
            ii(0x100d_5810, 6); lea(eax, ebp - 0x94);                   /* lea eax, [ebp-0x94] */
            ii(0x100d_5816, 5); calld(0x100d_5224, -0x5f7);             /* call 0x100d5224 */
            ii(0x100d_581b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_581c, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x100d_5822, 5); calld(0x100d_5250, -0x5d7);             /* call 0x100d5250 */
            ii(0x100d_5827, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5828, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x100d_582e, 5); calld(0x100d_527c, -0x5b7);             /* call 0x100d527c */
            ii(0x100d_5833, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5834, 6); lea(eax, ebp - 0xa0);                   /* lea eax, [ebp-0xa0] */
            ii(0x100d_583a, 5); calld(0x100d_52a8, -0x597);             /* call 0x100d52a8 */
            ii(0x100d_583f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5840, 5); calld(0x100d_52d4, -0x571);             /* call 0x100d52d4 */
            ii(0x100d_5845, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_5848, 5); calld(0x100d_52f8, -0x555);             /* call 0x100d52f8 */
            ii(0x100d_584d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_5850, 5); mov(edx, StringDefinitions.Cancel3);    /* mov edx, 0x101a1781 */
            ii(0x100d_5855, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5858, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x100d_585b, 5); calld(0x100c_ef64, -0x68fc);            /* call 0x100cef64 */
            ii(0x100d_5860, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x100d_5865, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5868, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x100d_586b, 5); calld(0x100d_5134, -0x73c);             /* call 0x100d5134 */
            ii(0x100d_5870, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x100d_5875, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5878, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x100d_587b, 5); calld(0x100d_5134, -0x74c);             /* call 0x100d5134 */
            ii(0x100d_5880, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x100d_5885, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5888, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x100d_588b, 5); calld(0x100d_5134, -0x75c);             /* call 0x100d5134 */
            ii(0x100d_5890, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_5897, 2); jmpd(0x100d_589f, 0x6); goto l_0x100d_589f; /* jmp 0x100d589f */
        l_0x100d_5899:
            ii(0x100d_5899, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_589c, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100d_589f:
            ii(0x100d_589f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_58a3, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100d_58a6, 6); if(jged(0x100d_5931, 0x85)) goto l_0x100d_5931; /* jge 0x100d5931 */
            ii(0x100d_58ac, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_58b0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_58b6, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100d_58bc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_58c1, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100d_58c4, 2); if(jnzd(0x100d_592c, 0x66)) goto l_0x100d_592c; /* jnz 0x100d592c */
            ii(0x100d_58c6, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_58ca, 6); lea(edx, eax + 0x3e9);                  /* lea edx, [eax+0x3e9] */
            ii(0x100d_58d0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_58d4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_58d7, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_58da, 3); mov(eax, memd_a32[ds, eax + 0x3e]);     /* mov eax, [eax+0x3e] */
            ii(0x100d_58dd, 5); calld(0x100d_5164, -0x77e);             /* call 0x100d5164 */
            ii(0x100d_58e2, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_58e6, 6); add(edx, 0x3e9);                        /* add edx, 0x3e9 */
            ii(0x100d_58ec, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_58f0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_58f3, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_58f6, 3); mov(eax, memd_a32[ds, eax + 0x3e]);     /* mov eax, [eax+0x3e] */
            ii(0x100d_58f9, 5); calld(0x100d_5134, -0x7ca);             /* call 0x100d5134 */
            ii(0x100d_58fe, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_5903, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_5907, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_590a, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_590d, 3); mov(eax, memd_a32[ds, eax + 0x3e]);     /* mov eax, [eax+0x3e] */
            ii(0x100d_5910, 5); calld(0x100d_5194, -0x781);             /* call 0x100d5194 */
            ii(0x100d_5915, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_591a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_591e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_5921, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_5924, 3); mov(eax, memd_a32[ds, eax + 0x3e]);     /* mov eax, [eax+0x3e] */
            ii(0x100d_5927, 5); calld(0x100d_50d4, -0x858);             /* call 0x100d50d4 */
        l_0x100d_592c:
            ii(0x100d_592c, 5); jmpd(0x100d_5899, -0x98); goto l_0x100d_5899; /* jmp 0x100d5899 */
        l_0x100d_5931:
            ii(0x100d_5931, 5); mov(edx, 0x701b);                       /* mov edx, 0x701b */
            ii(0x100d_5936, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5939, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x100d_593c, 5); calld(0x100d_5164, -0x7dd);             /* call 0x100d5164 */
            ii(0x100d_5941, 5); mov(edx, 0x700d);                       /* mov edx, 0x700d */
            ii(0x100d_5946, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5949, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x100d_594c, 5); calld(0x100d_5164, -0x7ed);             /* call 0x100d5164 */
            ii(0x100d_5951, 5); mov(edx, 0x73e8);                       /* mov edx, 0x73e8 */
            ii(0x100d_5956, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5959, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x100d_595c, 5); calld(0x100d_5164, -0x7fd);             /* call 0x100d5164 */
            ii(0x100d_5961, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100d_5966, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5969, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x100d_596c, 5); calld(0x100d_50d4, -0x89d);             /* call 0x100d50d4 */
            ii(0x100d_5971, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x100d_5976, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5979, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x100d_597c, 5); calld(0x100d_50d4, -0x8ad);             /* call 0x100d50d4 */
            ii(0x100d_5981, 5); mov(edx, 0x4e5);                        /* mov edx, 0x4e5 */
            ii(0x100d_5986, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5989, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x100d_598c, 5); calld(0x100d_50d4, -0x8bd);             /* call 0x100d50d4 */
            ii(0x100d_5991, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5994, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_5997, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_599a, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x100d_599d, 5); calld(0x100c_f85c, -0x6146);            /* call 0x100cf85c */
            ii(0x100d_59a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_59a5, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_59a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_59ab, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x100d_59ae, 5); calld(0x100c_f85c, -0x6157);            /* call 0x100cf85c */
            ii(0x100d_59b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_59b6, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_59b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_59bc, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x100d_59bf, 5); calld(0x100c_f85c, -0x6168);            /* call 0x100cf85c */
            ii(0x100d_59c4, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_59cb, 2); jmpd(0x100d_59d3, 0x6); goto l_0x100d_59d3; /* jmp 0x100d59d3 */
        l_0x100d_59cd:
            ii(0x100d_59cd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_59d0, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100d_59d3:
            ii(0x100d_59d3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_59d7, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100d_59da, 2); if(jged(0x100d_59f6, 0x1a)) goto l_0x100d_59f6; /* jge 0x100d59f6 */
            ii(0x100d_59dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_59df, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_59e2, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_59e6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_59e9, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_59ec, 3); mov(eax, memd_a32[ds, eax + 0x3e]);     /* mov eax, [eax+0x3e] */
            ii(0x100d_59ef, 5); calld(0x100c_f85c, -0x6198);            /* call 0x100cf85c */
            ii(0x100d_59f4, 2); jmpd(0x100d_59cd, -0x29); goto l_0x100d_59cd; /* jmp 0x100d59cd */
        l_0x100d_59f6:
            ii(0x100d_59f6, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_59fd, 2); jmpd(0x100d_5a05, 0x6); goto l_0x100d_5a05; /* jmp 0x100d5a05 */
        l_0x100d_59ff:
            ii(0x100d_59ff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_5a02, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100d_5a05:
            ii(0x100d_5a05, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_5a09, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100d_5a0c, 2); if(jged(0x100d_5a48, 0x3a)) goto l_0x100d_5a48; /* jge 0x100d5a48 */
            ii(0x100d_5a0e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_5a12, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_5a18, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100d_5a1e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_5a23, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100d_5a26, 2); if(jnzd(0x100d_5a46, 0x1e)) goto l_0x100d_5a46; /* jnz 0x100d5a46 */
            ii(0x100d_5a28, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_5a2c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5a2e, 6); mov(dl, memb_a32[ds, eax + 0x101c_3934]); /* mov dl, [eax+0x101c3934] */
            ii(0x100d_5a34, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_5a38, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_5a3b, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100d_5a3e, 3); mov(eax, memd_a32[ds, eax + 0x3e]);     /* mov eax, [eax+0x3e] */
            ii(0x100d_5a41, 5); calld(0x100c_fb73, -0x5ed3);            /* call 0x100cfb73 */
        l_0x100d_5a46:
            ii(0x100d_5a46, 2); jmpd(0x100d_59ff, -0x49); goto l_0x100d_59ff; /* jmp 0x100d59ff */
        l_0x100d_5a48:
            ii(0x100d_5a48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5a4b, 4); mov(memb_a32[ds, eax + 0x52], 0);       /* mov byte [eax+0x52], 0x0 */
            ii(0x100d_5a4f, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x100d_5a54, 5); calld(Definitions.sys_new, 0x9_03a7);   /* call 0x10165e00 */
            ii(0x100d_5a59, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100d_5a5f, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100d_5a65, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100d_5a6b, 7); cmp(memd_a32[ss, ebp - 0xa8], 0);       /* cmp dword [ebp-0xa8], 0x0 */
            ii(0x100d_5a72, 2); if(jzd(0x100d_5ac8, 0x54)) goto l_0x100d_5ac8; /* jz 0x100d5ac8 */
            ii(0x100d_5a74, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_5a79, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5a7a, 5); mov(eax, 0xa2);                         /* mov eax, 0xa2 */
            ii(0x100d_5a7f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5a80, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x100d_5a85, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5a86, 5); mov(eax, 0x17c);                        /* mov eax, 0x17c */
            ii(0x100d_5a8b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5a8c, 5); mov(eax, 0x57);                         /* mov eax, 0x57 */
            ii(0x100d_5a91, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5a92, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x100d_5a97, 1); pushd(eax);                             /* push eax */
            ii(0x100d_5a98, 5); mov(ecx, 0x3c);                         /* mov ecx, 0x3c */
            ii(0x100d_5a9d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_5aa0, 3); add(ebx, 0x52);                         /* add ebx, 0x52 */
            ii(0x100d_5aa3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_5aa6, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_5aa9, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100d_5aaf, 5); calld(0x100e_af58, 0x1_54a4);           /* call 0x100eaf58 */
            ii(0x100d_5ab4, 6); mov(memd_a32[ss, ebp - 0xac], eax);     /* mov [ebp-0xac], eax */
            ii(0x100d_5aba, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100d_5ac0, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
            ii(0x100d_5ac6, 2); jmpd(0x100d_5ad4, 0xc); goto l_0x100d_5ad4; /* jmp 0x100d5ad4 */
        l_0x100d_5ac8:
            ii(0x100d_5ac8, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100d_5ace, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
        l_0x100d_5ad4:
            ii(0x100d_5ad4, 6); mov(eax, memd_a32[ss, ebp - 0xb0]);     /* mov eax, [ebp-0xb0] */
            ii(0x100d_5ada, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_5add, 3); mov(memd_a32[ds, edx + 0x4e], eax);     /* mov [edx+0x4e], eax */
            ii(0x100d_5ae0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5ae2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5ae5, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_5ae8, 5); calld(0x100d_60d4, 0x5e7);              /* call 0x100d60d4 */
            ii(0x100d_5aed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5af0, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_5af3, 5); calld(0x100e_b180, 0x1_5688);           /* call 0x100eb180 */
            ii(0x100d_5af8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_5afb, 3); add(edx, 0x52);                         /* add edx, 0x52 */
            ii(0x100d_5afe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5b01, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_5b04, 5); calld(0x100e_b14d, 0x1_5644);           /* call 0x100eb14d */
            ii(0x100d_5b09, 5); calld(0x100d_6104, 0x5f6);              /* call 0x100d6104 */
            ii(0x100d_5b0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_5b10, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_5b12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5b15, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_5b18, 5); calld(0x100e_b5e1, 0x1_5ac4);           /* call 0x100eb5e1 */
            ii(0x100d_5b1d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5b20, 3); mov(eax, memd_a32[ds, eax + 0x4e]);     /* mov eax, [eax+0x4e] */
            ii(0x100d_5b23, 5); calld(0x100e_b1b2, 0x1_568a);           /* call 0x100eb1b2 */
            ii(0x100d_5b28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5b2b, 5); calld(0x100d_5cbd, 0x18d);              /* call 0x100d5cbd */
            ii(0x100d_5b30, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_5b33, 6); mov(memd_a32[ss, ebp - 0xb4], eax);     /* mov [ebp-0xb4], eax */
            ii(0x100d_5b39, 6); mov(eax, memd_a32[ss, ebp - 0xb4]);     /* mov eax, [ebp-0xb4] */
            ii(0x100d_5b3f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5b41, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_5b42, 1); popd(edi);                              /* pop edi */
            ii(0x100d_5b43, 1); popd(esi);                              /* pop esi */
            ii(0x100d_5b44, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5b45, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5b46, 1); retd(); return;                         /* ret */
        }
    }
}
