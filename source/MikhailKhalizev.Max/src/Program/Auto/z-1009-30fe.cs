using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("13da4720-a651-43f4-9b22-62fc7cec5f76")]
        public void Method_1009_30fe()
        {
            ii(0x1009_30fe, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1009_3103, 5); calld(Definitions.sys_check_available_stack_size, 0xd_2c4a); /* call 0x10165d52 */
            ii(0x1009_3108, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_3109, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_310a, 1); pushd(esi);                             /* push esi */
            ii(0x1009_310b, 1); pushd(edi);                             /* push edi */
            ii(0x1009_310c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_310d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_310f, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1009_3115, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_3118, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_311b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_311e, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1009_3122, 2); if(jzd(0x1009_318e, 0x6a)) goto l_0x1009_318e; /* jz 0x1009318e */
            ii(0x1009_3124, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_3127, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_312a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_312d, 5); calld(0x1008_ab1c, -0x8616);            /* call 0x1008ab1c */
            ii(0x1009_3132, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_3135, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1009_3139, 2); if(jzd(0x1009_3144, 0x9)) goto l_0x1009_3144; /* jz 0x10093144 */
            ii(0x1009_313b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_313e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x15);    /* cmp byte [eax+0x3d], 0x15 */
            ii(0x1009_3142, 2); if(jnzd(0x1009_3189, 0x45)) goto l_0x1009_3189; /* jnz 0x10093189 */
        l_0x1009_3144:
            ii(0x1009_3144, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1009_3149, 5); calld(Definitions.sys_new, 0xd_2cb2);   /* call 0x10165e00 */
            ii(0x1009_314e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_3151, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_3154, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_3157, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_315b, 2); if(jzd(0x1009_3176, 0x19)) goto l_0x1009_3176; /* jz 0x10093176 */
            ii(0x1009_315d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1009_3160, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_3163, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_3166, 5); calld(Definitions.my_ctor_c3, 0x56e7);  /* call 0x10098852 */
            ii(0x1009_316b, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_316e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_3171, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_3174, 2); jmpd(0x1009_317c, 0x6); goto l_0x1009_317c; /* jmp 0x1009317c */
        l_0x1009_3176:
            ii(0x1009_3176, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_3179, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1009_317c:
            ii(0x1009_317c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_317f, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_3184, 5); calld(0x100a_4d50, 0x1_1bc7);           /* call 0x100a4d50 */
        l_0x1009_3189:
            ii(0x1009_3189, 5); jmpd(0x1009_3206, 0x78); goto l_0x1009_3206; /* jmp 0x10093206 */
        l_0x1009_318e:
            ii(0x1009_318e, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1009_3193, 5); calld(Definitions.sys_new, 0xd_2c68);   /* call 0x10165e00 */
            ii(0x1009_3198, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_319b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_319e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_31a1, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1009_31a5, 2); if(jzd(0x1009_31c0, 0x19)) goto l_0x1009_31c0; /* jz 0x100931c0 */
            ii(0x1009_31a7, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1009_31aa, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_31ad, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_31b0, 5); calld(Definitions.my_ctor_c2, -0x66cb); /* call 0x1008caea */
            ii(0x1009_31b5, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_31b8, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_31bb, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_31be, 2); jmpd(0x1009_31c6, 0x6); goto l_0x1009_31c6; /* jmp 0x100931c6 */
        l_0x1009_31c0:
            ii(0x1009_31c0, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_31c3, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1009_31c6:
            ii(0x1009_31c6, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1009_31c9, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_31cc, 5); calld(0x1009_c7e0, 0x960f);             /* call 0x1009c7e0 */
            ii(0x1009_31d1, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_31d4, 5); calld(0x1009_c76c, 0x9593);             /* call 0x1009c76c */
            ii(0x1009_31d9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_31db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_31de, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_31e1, 5); calld(0x1009_c698, 0x94b2);             /* call 0x1009c698 */
            ii(0x1009_31e6, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_31e9, 5); calld(0x1009_c76c, 0x957e);             /* call 0x1009c76c */
            ii(0x1009_31ee, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x1009_31f3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_31f5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_31f7, 5); calld(0x100a_4d50, 0x1_1b54);           /* call 0x100a4d50 */
            ii(0x1009_31fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_31fe, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_3201, 5); calld(0x1009_b9ec, 0x87e6);             /* call 0x1009b9ec */
        l_0x1009_3206:
            ii(0x1009_3206, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3208, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_3209, 1); popd(edi);                              /* pop edi */
            ii(0x1009_320a, 1); popd(esi);                              /* pop esi */
            ii(0x1009_320b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_320c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_320d, 1); retd(); return;                         /* ret */
        }
    }
}
