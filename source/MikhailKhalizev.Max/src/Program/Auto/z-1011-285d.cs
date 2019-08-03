using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("865c65aa-311f-432d-a822-235af4f3fcf4")]
        public void Method_1011_285d()
        {
            ii(0x1011_285d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_2862, 5); calld(Definitions.sys_check_available_stack_size, 0x534eb); /* call 0x10165d52 */
            ii(0x1011_2867, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_2868, 1); pushd(esi);                             /* push esi */
            ii(0x1011_2869, 1); pushd(edi);                             /* push edi */
            ii(0x1011_286a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_286b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_286d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_2873, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_2876, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x1011_2879, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1011_287c, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_2880, 2); if(jzd(0x1011_28c4, 0x42)) goto l_0x1011_28c4; /* jz 0x101128c4 */
            ii(0x1011_2882, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1011_2886, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2889, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1011_288c, 4); cmp(memd_a32[ds, eax + 0x16], 0);       /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_2890, 2); if(jnzd(0x1011_289e, 0xc)) goto l_0x1011_289e; /* jnz 0x1011289e */
            ii(0x1011_2892, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1011_2896, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_2899, 5); calld(0x1011_241a, -0x484);             /* call 0x1011241a */
        l_0x1011_289e:
            ii(0x1011_289e, 5); calld(0x100d_51e4, -0x3d6bf);           /* call 0x100d51e4 */
            ii(0x1011_28a3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_28a5, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_28a7, 5); calld(0x100d_5204, -0x3d6a8);           /* call 0x100d5204 */
            ii(0x1011_28ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_28ae, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_28b0, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1011_28b4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_28b7, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1011_28ba, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_28bd, 5); calld(0x100c_fa7c, -0x42e46);           /* call 0x100cfa7c */
            ii(0x1011_28c2, 2); jmpd(0x1011_28ef, 0x2b); goto l_0x1011_28ef; /* jmp 0x101128ef */
        l_0x1011_28c4:
            ii(0x1011_28c4, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1011_28c8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_28cb, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1011_28ce, 4); cmp(memd_a32[ds, eax + 0x16], 0);       /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_28d2, 2); if(jzd(0x1011_28ef, 0x1b)) goto l_0x1011_28ef; /* jz 0x101128ef */
            ii(0x1011_28d4, 5); calld(0x100d_51c4, -0x3d715);           /* call 0x100d51c4 */
            ii(0x1011_28d9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_28db, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_28dd, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1011_28e1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_28e4, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1011_28e7, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_28ea, 5); calld(0x100c_fb06, -0x42de9);           /* call 0x100cfb06 */
        l_0x1011_28ef:
            ii(0x1011_28ef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_28f1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_28f2, 1); popd(edi);                              /* pop edi */
            ii(0x1011_28f3, 1); popd(esi);                              /* pop esi */
            ii(0x1011_28f4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_28f5, 1); retd(); return;                         /* ret */
        }
    }
}
