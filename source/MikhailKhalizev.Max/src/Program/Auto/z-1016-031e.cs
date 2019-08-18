using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e3a558f-dabb-497d-a5cc-c26642ac0991")]
        public void Method_1016_031e()
        {
            ii(0x1016_031e, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1016_0323, 5); calld(Definitions.sys_check_available_stack_size, 0x5a2a); /* call 0x10165d52 */
            ii(0x1016_0328, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_0329, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_032a, 1); pushd(edx);                             /* push edx */
            ii(0x1016_032b, 1); pushd(esi);                             /* push esi */
            ii(0x1016_032c, 1); pushd(edi);                             /* push edi */
            ii(0x1016_032d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_032e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_0330, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1016_0336, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_0339, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_033c, 5); calld(0x1007_611c, -0xe_a225);          /* call 0x1007611c */
            ii(0x1016_0341, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1016_0344, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0346, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_0348, 5); calld(0x1007_66ac, -0xe_9ca1);          /* call 0x100766ac */
            ii(0x1016_034d, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_0352, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_0355, 5); calld(0x1007_6d98, -0xe_95c2);          /* call 0x10076d98 */
            ii(0x1016_035a, 2); test(al, al);                           /* test al, al */
            ii(0x1016_035c, 2); if(jzd(0x1016_0375, 0x17)) goto l_0x1016_0375; /* jz 0x10160375 */
            ii(0x1016_035e, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_0363, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1016_0368, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_036b, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_0370, 5); calld(0x1013_d5c0, -0x2_2db5);          /* call 0x1013d5c0 */
        l_0x1016_0375:
            ii(0x1016_0375, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_0378, 5); calld(0x1007_6204, -0xe_a179);          /* call 0x10076204 */
            ii(0x1016_037d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_037f, 2); if(jzd(0x1016_03d3, 0x52)) goto l_0x1016_03d3; /* jz 0x101603d3 */
            ii(0x1016_0381, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1016_0384, 5); calld(0x1007_20b1, -0xe_e2d8);          /* call 0x100720b1 */
            ii(0x1016_0389, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1016_038c, 5); calld(0x1007_20b1, -0xe_e2e0);          /* call 0x100720b1 */
            ii(0x1016_0391, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1016_0394, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1016_0397, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_039a, 5); calld(0x1007_6204, -0xe_a19b);          /* call 0x10076204 */
            ii(0x1016_039f, 5); calld(0x1014_3616, -0x1_cd8e);          /* call 0x10143616 */
            ii(0x1016_03a4, 4); movsx(edx, memw_a32[ss, ebp - 0x16]);   /* movsx edx, word [ebp-0x16] */
            ii(0x1016_03a8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_03ab, 5); calld(0x1007_6574, -0xe_9e3c);          /* call 0x10076574 */
            ii(0x1016_03b0, 5); calld(0x1015_01b7, -0x1_01fe);          /* call 0x101501b7 */
            ii(0x1016_03b5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_03b8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_03ba, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_03bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_03bf, 2); neg(eax);                               /* neg eax */
            ii(0x1016_03c1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_03c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_03c7, 5); calld(0x1007_6204, -0xe_a1c8);          /* call 0x10076204 */
            ii(0x1016_03cc, 5); calld(0x100d_7a9c, -0x8_8935);          /* call 0x100d7a9c */
            ii(0x1016_03d1, 2); jmpd(0x1016_03f6, 0x23); goto l_0x1016_03f6; /* jmp 0x101603f6 */
        l_0x1016_03d3:
            ii(0x1016_03d3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_03d6, 3); mov(edx, memd_a32[ds, edx + 0x50]);     /* mov edx, [edx+0x50] */
            ii(0x1016_03d9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_03dc, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_03df, 5); calld(0x1007_6574, -0xe_9e70);          /* call 0x10076574 */
            ii(0x1016_03e4, 5); calld(0x1015_01b7, -0x1_0232);          /* call 0x101501b7 */
            ii(0x1016_03e9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_03ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_03ef, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_03f2, 4); sub(memw_a32[ds, edx + 0x52], ax);      /* sub [edx+0x52], ax */
        l_0x1016_03f6:
            ii(0x1016_03f6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_03f8, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1016_03fd, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_0400, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_0403, 5); calld(0x1007_6574, -0xe_9e94);          /* call 0x10076574 */
            ii(0x1016_0408, 5); calld(0x1007_6074, -0xe_a399);          /* call 0x10076074 */
            ii(0x1016_040d, 2); test(al, al);                           /* test al, al */
            ii(0x1016_040f, 2); if(jzd(0x1016_041e, 0xd)) goto l_0x1016_041e; /* jz 0x1016041e */
            ii(0x1016_0411, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_0414, 5); calld(0x1007_6574, -0xe_9ea5);          /* call 0x10076574 */
            ii(0x1016_0419, 5); calld(0x1014_9fa8, -0x1_6476);          /* call 0x10149fa8 */
        l_0x1016_041e:
            ii(0x1016_041e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_0421, 5); calld(0x1014_f08b, -0x1_139b);          /* call 0x1014f08b */
            ii(0x1016_0426, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_042b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_042e, 5); calld(0x1007_6d98, -0xe_969b);          /* call 0x10076d98 */
            ii(0x1016_0433, 2); test(al, al);                           /* test al, al */
            ii(0x1016_0435, 2); if(jzd(0x1016_043f, 0x8)) goto l_0x1016_043f; /* jz 0x1016043f */
            ii(0x1016_0437, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_043a, 5); calld(0x1010_094d, -0x5_faf2);          /* call 0x1010094d */
        l_0x1016_043f:
            ii(0x1016_043f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_0444, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_0447, 5); calld(0x1007_6574, -0xe_9ed8);          /* call 0x10076574 */
            ii(0x1016_044c, 5); calld(0x1015_2605, -0xde4c);            /* call 0x10152605 */
            ii(0x1016_0451, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0453, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_0456, 5); calld(0x1007_5f2c, -0xe_a52f);          /* call 0x10075f2c */
            ii(0x1016_045b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_045d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_045e, 1); popd(edi);                              /* pop edi */
            ii(0x1016_045f, 1); popd(esi);                              /* pop esi */
            ii(0x1016_0460, 1); popd(edx);                              /* pop edx */
            ii(0x1016_0461, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_0462, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_0463, 1); retd(); return;                         /* ret */
        }
    }
}
