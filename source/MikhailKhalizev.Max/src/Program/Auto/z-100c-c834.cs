using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("14c5552d-17ed-4f19-a8b4-d36cfdf8df1c")]
        public void Method_100c_c834()
        {
            ii(0x100c_c834, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_c839, 5); calld(Definitions.sys_check_available_stack_size, 0x9_9514); /* call 0x10165d52 */
            ii(0x100c_c83e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_c83f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_c840, 1); pushd(edx);                             /* push edx */
            ii(0x100c_c841, 1); pushd(esi);                             /* push esi */
            ii(0x100c_c842, 1); pushd(edi);                             /* push edi */
            ii(0x100c_c843, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_c844, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_c846, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_c84c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_c84f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c852, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c855, 5); calld(0x1007_65d0, -0x5_628a);          /* call 0x100765d0 */
            ii(0x100c_c85a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c85c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c85f, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c862, 5); calld(0x1007_6574, -0x5_62f3);          /* call 0x10076574 */
            ii(0x100c_c867, 5); calld(0x1008_a998, -0x4_1ed4);          /* call 0x1008a998 */
            ii(0x100c_c86c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c86f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c872, 5); calld(0x1007_6574, -0x5_6303);          /* call 0x10076574 */
            ii(0x100c_c877, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c879, 3); mov(dl, memb_a32[ds, eax + 0x4d]);      /* mov dl, [eax+0x4d] */
            ii(0x100c_c87c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c87f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c882, 5); calld(0x1007_6574, -0x5_6313);          /* call 0x10076574 */
            ii(0x100c_c887, 5); calld(0x1007_623c, -0x5_6650);          /* call 0x1007623c */
            ii(0x100c_c88c, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_c88f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_c892, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_c894, 2); if(jged(0x100c_c8af, 0x19)) goto l_0x100c_c8af; /* jge 0x100cc8af */
            ii(0x100c_c896, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_c898, 5); mov(edx, 0x11);                         /* mov edx, 0x11 */
            ii(0x100c_c89d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c8a0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c8a3, 5); calld(0x1007_65d0, -0x5_62d8);          /* call 0x100765d0 */
            ii(0x100c_c8a8, 5); calld(0x1016_3053, 0x9_67a6);           /* call 0x10163053 */
            ii(0x100c_c8ad, 2); jmpd(0x100c_c903, 0x54); goto l_0x100c_c903; /* jmp 0x100cc903 */
        l_0x100c_c8af:
            ii(0x100c_c8af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c8b2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c8b5, 5); calld(0x1007_6574, -0x5_6346);          /* call 0x10076574 */
            ii(0x100c_c8ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c8bc, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x100c_c8bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c8c2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c8c5, 5); calld(0x1007_6574, -0x5_6356);          /* call 0x10076574 */
            ii(0x100c_c8ca, 5); calld(0x1007_623c, -0x5_6693);          /* call 0x1007623c */
            ii(0x100c_c8cf, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100c_c8d2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_c8d5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_c8d7, 2); if(jged(0x100c_c8ea, 0x11)) goto l_0x100c_c8ea; /* jge 0x100cc8ea */
            ii(0x100c_c8d9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c8dc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c8df, 5); calld(0x1007_6574, -0x5_6370);          /* call 0x10076574 */
            ii(0x100c_c8e4, 4); cmp(memb_a32[ds, eax + 0x3e], 0x3);     /* cmp byte [eax+0x3e], 0x3 */
            ii(0x100c_c8e8, 2); if(jzd(0x100c_c8ec, 0x2)) goto l_0x100c_c8ec; /* jz 0x100cc8ec */
        l_0x100c_c8ea:
            ii(0x100c_c8ea, 2); jmpd(0x100c_c903, 0x17); goto l_0x100c_c903; /* jmp 0x100cc903 */
        l_0x100c_c8ec:
            ii(0x100c_c8ec, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_c8ee, 5); mov(edx, 0x13);                         /* mov edx, 0x13 */
            ii(0x100c_c8f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c8f6, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c8f9, 5); calld(0x1007_65d0, -0x5_632e);          /* call 0x100765d0 */
            ii(0x100c_c8fe, 5); calld(0x1016_3053, 0x9_6750);           /* call 0x10163053 */
        l_0x100c_c903:
            ii(0x100c_c903, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_c905, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_c906, 1); popd(edi);                              /* pop edi */
            ii(0x100c_c907, 1); popd(esi);                              /* pop esi */
            ii(0x100c_c908, 1); popd(edx);                              /* pop edx */
            ii(0x100c_c909, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_c90a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_c90b, 1); retd(); return;                         /* ret */
        }
    }
}
