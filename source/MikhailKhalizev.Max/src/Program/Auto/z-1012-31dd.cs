using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2c8680e8-fa53-4a1e-8d1d-80026b98850c")]
        public void Method_1012_31dd()
        {
            ii(0x1012_31dd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_31e2, 5); calld(Definitions.sys_check_available_stack_size, 0x42b6b); /* call 0x10165d52 */
            ii(0x1012_31e7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_31e8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_31e9, 1); pushd(edx);                             /* push edx */
            ii(0x1012_31ea, 1); pushd(esi);                             /* push esi */
            ii(0x1012_31eb, 1); pushd(edi);                             /* push edi */
            ii(0x1012_31ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_31ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_31ef, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_31f5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_31f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_31fb, 4); mov(memb_a32[ds, eax + 0x31], 0);       /* mov byte [eax+0x31], 0x0 */
            ii(0x1012_31ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3202, 4); mov(memb_a32[ds, eax + 0x4b], 0);       /* mov byte [eax+0x4b], 0x0 */
        l_0x1012_3206:
            ii(0x1012_3206, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3209, 4); cmp(memb_a32[ds, eax + 0x31], 0);       /* cmp byte [eax+0x31], 0x0 */
            ii(0x1012_320d, 6); if(jnzd(0x1012_3277, 0x64)) goto l_0x1012_3277; /* jnz 0x10123277 */
            ii(0x1012_3213, 5); calld(/* sys */ 0x1016_b208, 0x47ff0);  /* call 0x1016b208 */
            ii(0x1012_3218, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_321b, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_321f, 2); if(jled(0x1012_322a, 0x9)) goto l_0x1012_322a; /* jle 0x1012322a */
            ii(0x1012_3221, 7); cmp(memd_a32[ss, ebp - 0x8], 0x7000);   /* cmp dword [ebp-0x8], 0x7000 */
            ii(0x1012_3228, 2); if(jld(0x1012_322c, 0x2)) goto l_0x1012_322c; /* jl 0x1012322c */
        l_0x1012_322a:
            ii(0x1012_322a, 2); jmpd(0x1012_3233, 0x7); goto l_0x1012_3233; /* jmp 0x10123233 */
        l_0x1012_322c:
            ii(0x1012_322c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_322f, 4); mov(memb_a32[ds, eax + 0x4b], 0);       /* mov byte [eax+0x4b], 0x0 */
        l_0x1012_3233:
            ii(0x1012_3233, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3236, 6); cmp(memw_a32[ds, eax + 0x40], 0x6cd);   /* cmp word [eax+0x40], 0x6cd */
            ii(0x1012_323c, 2); if(jnzd(0x1012_326a, 0x2c)) goto l_0x1012_326a; /* jnz 0x1012326a */
            ii(0x1012_323e, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_3245, 2); if(jzd(0x1012_326a, 0x23)) goto l_0x1012_326a; /* jz 0x1012326a */
            ii(0x1012_3247, 7); cmp(memb_a32[ds, 0x101c_37d2], 0);      /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1012_324e, 2); if(jzd(0x1012_3257, 0x7)) goto l_0x1012_3257; /* jz 0x10123257 */
            ii(0x1012_3250, 7); mov(memd_a32[ss, ebp - 0x8], 0x3e9);    /* mov dword [ebp-0x8], 0x3e9 */
        l_0x1012_3257:
            ii(0x1012_3257, 5); calld(0x100d_5094, -0x4e1c8);           /* call 0x100d5094 */
            ii(0x1012_325c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_325e, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1012_3260, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_3265, 5); calld(0x1010_0e32, -0x22438);           /* call 0x10100e32 */
        l_0x1012_326a:
            ii(0x1012_326a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_326d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3270, 5); calld(0x1012_29ad, -0x8c8);             /* call 0x101229ad */
            ii(0x1012_3275, 2); jmpd(0x1012_3206, -0x71); goto l_0x1012_3206; /* jmp 0x10123206 */
        l_0x1012_3277:
            ii(0x1012_3277, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_327e, 2); if(jnzd(0x1012_328a, 0xa)) goto l_0x1012_328a; /* jnz 0x1012328a */
            ii(0x1012_3280, 5); calld(0x1014_82f4, 0x2506f);            /* call 0x101482f4 */
            ii(0x1012_3285, 5); mov(memd_a32[ds, 0x101c_396c], eax);    /* mov [0x101c396c], eax */
        l_0x1012_328a:
            ii(0x1012_328a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_328c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_328d, 1); popd(edi);                              /* pop edi */
            ii(0x1012_328e, 1); popd(esi);                              /* pop esi */
            ii(0x1012_328f, 1); popd(edx);                              /* pop edx */
            ii(0x1012_3290, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_3291, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_3292, 1); retd(); return;                         /* ret */
        }
    }
}