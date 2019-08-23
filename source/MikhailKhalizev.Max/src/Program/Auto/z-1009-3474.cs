using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_3474-cf8766e6")]
        public void Method_1009_3474()
        {
            ii(0x1009_3474, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1009_3479, 5); calld(Definitions.sys_check_available_stack_size, 0xd_28d4); /* call 0x10165d52 */
            ii(0x1009_347e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_347f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_3480, 1); pushd(edx);                             /* push edx */
            ii(0x1009_3481, 1); pushd(esi);                             /* push esi */
            ii(0x1009_3482, 1); pushd(edi);                             /* push edi */
            ii(0x1009_3483, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_3484, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_3486, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_348c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_348f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_3492, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_c9a7); /* call 0x10076af0 */
            ii(0x1009_3497, 5); calld(0x100e_a7e7, 0x5_734b);           /* call 0x100ea7e7 */
            ii(0x1009_349c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_349f, 5); calld(0x1009_5463, 0x1fbf);             /* call 0x10095463 */
            ii(0x1009_34a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_34a7, 5); calld(0x1008_ad28, -0x8784);            /* call 0x1008ad28 */
            ii(0x1009_34ac, 2); test(al, al);                           /* test al, al */
            ii(0x1009_34ae, 2); if(jnzd(0x1009_3502, 0x52)) goto l_0x1009_3502; /* jnz 0x10093502 */
            ii(0x1009_34b0, 5); calld(0x1008_a7bc, -0x8cf9);            /* call 0x1008a7bc */
            ii(0x1009_34b5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_34ba, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_34bd, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1009_34c2, 5); calld(Definitions.sys_new, 0xd_2939);   /* call 0x10165e00 */
            ii(0x1009_34c7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_34ca, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_34cd, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_34d0, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_34d4, 2); if(jzd(0x1009_34ec, 0x16)) goto l_0x1009_34ec; /* jz 0x100934ec */
            ii(0x1009_34d6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_34d9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_34dc, 5); calld(Definitions.my_ctor_c11, 0x1_03e8); /* call 0x100a38c9 */
            ii(0x1009_34e1, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_34e4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_34e7, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_34ea, 2); jmpd(0x1009_34f2, 0x6); goto l_0x1009_34f2; /* jmp 0x100934f2 */
        l_0x1009_34ec:
            ii(0x1009_34ec, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_34ef, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1009_34f2:
            ii(0x1009_34f2, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1009_34f5, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_34fa, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1009_34fd, 5); calld(0x100a_4db6, 0x1_18b4);           /* call 0x100a4db6 */
        l_0x1009_3502:
            ii(0x1009_3502, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3504, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_3505, 1); popd(edi);                              /* pop edi */
            ii(0x1009_3506, 1); popd(esi);                              /* pop esi */
            ii(0x1009_3507, 1); popd(edx);                              /* pop edx */
            ii(0x1009_3508, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_3509, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_350a, 1); retd();                                 /* ret */
        }
    }
}
