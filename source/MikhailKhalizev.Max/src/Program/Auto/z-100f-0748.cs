using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e0ff40ac-faca-415a-ac6c-5c1f1bd15dd7")]
        public void Method_100f_0748()
        {
            ii(0x100f_0748, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_074d, 5); calld(Definitions.sys_check_available_stack_size, 0x75600); /* call 0x10165d52 */
            ii(0x100f_0752, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_0753, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_0754, 1); pushd(edx);                             /* push edx */
            ii(0x100f_0755, 1); pushd(esi);                             /* push esi */
            ii(0x100f_0756, 1); pushd(edi);                             /* push edi */
            ii(0x100f_0757, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_0758, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_075a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_0760, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_0763, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_076a, 2); jmpd(0x100f_0772, 0x6); goto l_0x100f_0772; /* jmp 0x100f0772 */
        l_0x100f_076c:
            ii(0x100f_076c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_076f, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100f_0772:
            ii(0x100f_0772, 4); cmp(memd_a32[ss, ebp - 0x8], 0x5);      /* cmp dword [ebp-0x8], 0x5 */
            ii(0x100f_0776, 2); if(jaed(0x100f_07a4, 0x2c)) goto l_0x100f_07a4; /* jae 0x100f07a4 */
            ii(0x100f_0778, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0xc); /* imul eax, [ebp-0x8], 0xc */
            ii(0x100f_077c, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_077f, 4); cmp(memd_a32[ds, eax + 0x10], 0);       /* cmp dword [eax+0x10], 0x0 */
            ii(0x100f_0783, 2); if(jzd(0x100f_07a2, 0x1d)) goto l_0x100f_07a2; /* jz 0x100f07a2 */
            ii(0x100f_0785, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0xc); /* imul eax, [ebp-0x8], 0xc */
            ii(0x100f_0789, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_078c, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100f_078f, 5); calld(Definitions.sys_free, 0x7a92d);   /* call 0x1016b0c1 */
            ii(0x100f_0794, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0xc); /* imul eax, [ebp-0x8], 0xc */
            ii(0x100f_0798, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_079b, 7); mov(memd_a32[ds, eax + 0x10], 0);       /* mov dword [eax+0x10], 0x0 */
        l_0x100f_07a2:
            ii(0x100f_07a2, 2); jmpd(0x100f_076c, -0x38); goto l_0x100f_076c; /* jmp 0x100f076c */
        l_0x100f_07a4:
            ii(0x100f_07a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_07a7, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100f_07aa, 2); if(jzd(0x100f_07bf, 0x13)) goto l_0x100f_07bf; /* jz 0x100f07bf */
            ii(0x100f_07ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_07af, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_07b1, 5); calld(Definitions.sys_fclose, 0x818b3); /* call 0x10172069 */
            ii(0x100f_07b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_07b9, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
        l_0x100f_07bf:
            ii(0x100f_07bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_07c2, 7); mov(memd_a32[ds, eax + 0x48], 0);       /* mov dword [eax+0x48], 0x0 */
            ii(0x100f_07c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_07cb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_07cc, 1); popd(edi);                              /* pop edi */
            ii(0x100f_07cd, 1); popd(esi);                              /* pop esi */
            ii(0x100f_07ce, 1); popd(edx);                              /* pop edx */
            ii(0x100f_07cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_07d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_07d1, 1); retd(); return;                         /* ret */
        }
    }
}