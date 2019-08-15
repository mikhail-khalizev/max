using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("894759b9-9d1f-4bbb-8ca9-0cd7bdfe5eb6")]
        public void Method_100a_72af()
        {
            ii(0x100a_72af, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_72b4, 5); calld(Definitions.sys_check_available_stack_size, 0xb_ea99); /* call 0x10165d52 */
            ii(0x100a_72b9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_72ba, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_72bb, 1); pushd(esi);                             /* push esi */
            ii(0x100a_72bc, 1); pushd(edi);                             /* push edi */
            ii(0x100a_72bd, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_72be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_72c0, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_72c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_72c9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_72cc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_72cf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_72d2, 5); calld(0x1008_b060, -0x1_c277);          /* call 0x1008b060 */
            ii(0x100a_72d7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_72da, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100a_72dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_72e0, 5); calld(0x1007_6d98, -0x3_054d);          /* call 0x10076d98 */
            ii(0x100a_72e5, 2); test(al, al);                           /* test al, al */
            ii(0x100a_72e7, 2); if(jzd(0x100a_7331, 0x48)) goto l_0x100a_7331; /* jz 0x100a7331 */
            ii(0x100a_72e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_72eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_72ee, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_72f1, 5); calld(0x1007_6630, -0x3_0cc6);          /* call 0x10076630 */
            ii(0x100a_72f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_72f9, 5); calld(0x100a_71f8, -0x106);             /* call 0x100a71f8 */
            ii(0x100a_72fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7300, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_7303, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_7306, 5); calld(0x1013_ad11, 0x9_3a06);           /* call 0x1013ad11 */
            ii(0x100a_730b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_730d, 2); if(jzd(0x100a_7320, 0x11)) goto l_0x100a_7320; /* jz 0x100a7320 */
            ii(0x100a_730f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7311, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_7314, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_7317, 5); calld(0x1013_ad11, 0x9_39f5);           /* call 0x1013ad11 */
            ii(0x100a_731c, 2); test(al, al);                           /* test al, al */
            ii(0x100a_731e, 2); if(jnzd(0x100a_7322, 0x2)) goto l_0x100a_7322; /* jnz 0x100a7322 */
        l_0x100a_7320:
            ii(0x100a_7320, 2); jmpd(0x100a_732f, 0xd); goto l_0x100a_732f; /* jmp 0x100a732f */
        l_0x100a_7322:
            ii(0x100a_7322, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_7325, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_732a, 5); calld(0x100a_5e27, -0x1508);            /* call 0x100a5e27 */
        l_0x100a_732f:
            ii(0x100a_732f, 2); jmpd(0x100a_7379, 0x48); goto l_0x100a_7379; /* jmp 0x100a7379 */
        l_0x100a_7331:
            ii(0x100a_7331, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_7334, 3); add(edx, 0x1b);                         /* add edx, 0x1b */
            ii(0x100a_7337, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_733a, 5); calld(0x1007_6d98, -0x3_05a7);          /* call 0x10076d98 */
            ii(0x100a_733f, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7341, 2); if(jzd(0x100a_735f, 0x1c)) goto l_0x100a_735f; /* jz 0x100a735f */
            ii(0x100a_7343, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7345, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_7348, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_734b, 5); calld(0x1007_6630, -0x3_0d20);          /* call 0x10076630 */
            ii(0x100a_7350, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7352, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_7355, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_7358, 5); calld(0x1007_6630, -0x3_0d2d);          /* call 0x10076630 */
            ii(0x100a_735d, 2); jmpd(0x100a_7379, 0x1a); goto l_0x100a_7379; /* jmp 0x100a7379 */
        l_0x100a_735f:
            ii(0x100a_735f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_7362, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100a_7365, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7368, 5); calld(0x1007_6d98, -0x3_05d5);          /* call 0x10076d98 */
            ii(0x100a_736d, 2); test(al, al);                           /* test al, al */
            ii(0x100a_736f, 2); if(jzd(0x100a_7379, 0x8)) goto l_0x100a_7379; /* jz 0x100a7379 */
            ii(0x100a_7371, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_7374, 5); calld(0x100a_71f8, -0x181);             /* call 0x100a71f8 */
        l_0x100a_7379:
            ii(0x100a_7379, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_737b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_737e, 5); calld(0x1008_8b7c, -0x1_e807);          /* call 0x10088b7c */
            ii(0x100a_7383, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7385, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7386, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7387, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7388, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_7389, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_738a, 1); retd(); return;                         /* ret */
        }
    }
}
