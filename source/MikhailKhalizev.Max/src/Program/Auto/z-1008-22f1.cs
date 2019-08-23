using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_22f1-2e352e76")]
        public void Method_1008_22f1()
        {
            ii(0x1008_22f1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_22f6, 5); calld(Definitions.sys_check_available_stack_size, 0xe_3a57); /* call 0x10165d52 */
            ii(0x1008_22fb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_22fc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_22fd, 1); pushd(esi);                             /* push esi */
            ii(0x1008_22fe, 1); pushd(edi);                             /* push edi */
            ii(0x1008_22ff, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_2300, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_2302, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_2308, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_230b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_230e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2311, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_2314, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_2317, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_231a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_231d, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x1008_2320, 2); cmp(al, 0x14);                          /* cmp al, 0x14 */
            ii(0x1008_2322, 6); if(jnzd(0x1008_239a, 0x72)) goto l_0x1008_239a; /* jnz 0x1008239a */
            ii(0x1008_2328, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_232b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_232e, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_2331, 5); calld(0x1008_9ca0, 0x796a);             /* call 0x10089ca0 */
            ii(0x1008_2336, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2339, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_233c, 5); calld(0x1008_9e08, 0x7ac7);             /* call 0x10089e08 */
            ii(0x1008_2341, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_2344, 2); if(jnzd(0x1008_2353, 0xd)) goto l_0x1008_2353; /* jnz 0x10082353 */
            ii(0x1008_2346, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2348, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_234b, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_234e, 5); calld(0x1008_9e38, 0x7ae5);             /* call 0x10089e38 */
        l_0x1008_2353:
            ii(0x1008_2353, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2356, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_2359, 5); calld(0x1007_6b90, -0xb7ce);            /* call 0x10076b90 */
            ii(0x1008_235e, 1); cwde();                                 /* cwde */
            ii(0x1008_235f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2361, 2); if(jnzd(0x1008_236d, 0xa)) goto l_0x1008_236d; /* jnz 0x1008236d */
            ii(0x1008_2363, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2366, 5); calld(0x1008_21dd, -0x18e);             /* call 0x100821dd */
            ii(0x1008_236b, 2); jmpd(0x1008_239a, 0x2d); goto l_0x1008_239a; /* jmp 0x1008239a */
        l_0x1008_236d:
            ii(0x1008_236d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_236f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2372, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_2375, 5); calld(0x1013_ad11, 0xb_8997);           /* call 0x1013ad11 */
            ii(0x1008_237a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_237c, 2); if(jnzd(0x1008_2392, 0x14)) goto l_0x1008_2392; /* jnz 0x10082392 */
            ii(0x1008_237e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2381, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_2384, 5); calld(0x1008_9d7c, 0x79f3);             /* call 0x10089d7c */
            ii(0x1008_2389, 5); calld(0x1008_9f70, 0x7be2);             /* call 0x10089f70 */
            ii(0x1008_238e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2390, 2); if(jnzd(0x1008_239a, 0x8)) goto l_0x1008_239a; /* jnz 0x1008239a */
        l_0x1008_2392:
            ii(0x1008_2392, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2395, 5); calld(0x1008_3369, 0xfcf);              /* call 0x10083369 */
        l_0x1008_239a:
            ii(0x1008_239a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_239c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_239d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_239e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_239f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_23a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_23a1, 1); retd();                                 /* ret */
        }
    }
}
