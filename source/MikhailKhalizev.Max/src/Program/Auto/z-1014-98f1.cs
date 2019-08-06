using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5508823-8fa3-4450-83ff-00130fc3f403")]
        public void Method_1014_98f1()
        {
            ii(0x1014_98f1, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_98f6, 5); calld(Definitions.sys_check_available_stack_size, 0x1c457); /* call 0x10165d52 */
            ii(0x1014_98fb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_98fc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_98fd, 1); pushd(esi);                             /* push esi */
            ii(0x1014_98fe, 1); pushd(edi);                             /* push edi */
            ii(0x1014_98ff, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_9900, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_9902, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_9908, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_990b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_990e, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_9912, 2); if(jzd(0x1014_991d, 0x9)) goto l_0x1014_991d; /* jz 0x1014991d */
            ii(0x1014_9914, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_991b, 2); jmpd(0x1014_9936, 0x19); goto l_0x1014_9936; /* jmp 0x10149936 */
        l_0x1014_991d:
            ii(0x1014_991d, 5); mov(ecx, 0x169);                        /* mov ecx, 0x169 */
            ii(0x1014_9922, 5); mov(ebx, StringDefinitions.UnitinfoCpp3); /* mov ebx, 0x101ad245 */
            ii(0x1014_9927, 5); mov(edx, StringDefinitions.Data0);      /* mov edx, 0x101ad252 */
            ii(0x1014_992c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_992e, 5); calld(Definitions.sys_assert, 0x1c45f); /* call 0x10165d92 */
            ii(0x1014_9933, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1014_9936:
            ii(0x1014_9936, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9939, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_993c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_9940, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_9942, 2); if(jld(0x1014_994f, 0xb)) goto l_0x1014_994f; /* jl 0x1014994f */
            ii(0x1014_9944, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9947, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_994a, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1014_994d, 2); if(jld(0x1014_9951, 0x2)) goto l_0x1014_9951; /* jl 0x10149951 */
        l_0x1014_994f:
            ii(0x1014_994f, 2); jmpd(0x1014_995a, 0x9); goto l_0x1014_995a; /* jmp 0x1014995a */
        l_0x1014_9951:
            ii(0x1014_9951, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1014_9958, 2); jmpd(0x1014_9973, 0x19); goto l_0x1014_9973; /* jmp 0x10149973 */
        l_0x1014_995a:
            ii(0x1014_995a, 5); mov(ecx, 0x16b);                        /* mov ecx, 0x16b */
            ii(0x1014_995f, 5); mov(ebx, StringDefinitions.UnitinfoCpp2); /* mov ebx, 0x101ad25c */
            ii(0x1014_9964, 5); mov(edx, StringDefinitions.Index0IndexAnglesUnitangletotal); /* mov edx, 0x101ad269 */
            ii(0x1014_9969, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_996b, 5); calld(Definitions.sys_assert, 0x1c422); /* call 0x10165d92 */
            ii(0x1014_9970, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1014_9973:
            ii(0x1014_9973, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_9977, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1014_997a, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1014_997d, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1014_9980, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_9983, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_9986, 3); add(eax, memd_a32[ss, ebp - 0x18]);     /* add eax, [ebp-0x18] */
            ii(0x1014_9989, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_998c, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_998f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_9991, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_9992, 1); popd(edi);                              /* pop edi */
            ii(0x1014_9993, 1); popd(esi);                              /* pop esi */
            ii(0x1014_9994, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_9995, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_9996, 1); retd(); return;                         /* ret */
        }
    }
}
