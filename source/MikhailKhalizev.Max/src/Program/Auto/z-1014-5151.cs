using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("24ca4be4-8428-4c73-b137-8e88046d78fa")]
        public void Method_1014_5151()
        {
            ii(0x1014_5151, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_5156, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0bf7); /* call 0x10165d52 */
            ii(0x1014_515b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_515c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_515d, 1); pushd(esi);                             /* push esi */
            ii(0x1014_515e, 1); pushd(edi);                             /* push edi */
            ii(0x1014_515f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5160, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5162, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_5168, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_516b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_516e, 1); int3();                                 /* int3 */
            ii(0x1014_516f, 5); calld(/* sys */ 0x1016_66b0, 0x2_153c); /* call 0x101666b0 */
            ii(0x1014_5174, 5); calld(/* sys */ 0x1017_1880, 0x2_c707); /* call 0x10171880 */
            ii(0x1014_5179, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_517c, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1014_517f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_5182, 1); pushd(eax);                             /* push eax */
            ii(0x1014_5183, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5186, 3); mov(ecx, memd_a32[ds, eax + 0xe]);      /* mov ecx, [eax+0xe] */
            ii(0x1014_5189, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_518c, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1014_518f, 5); calld(Definitions.my_strobj_c_str_v2, -0xb_b9cc); /* call 0x100897c8 */
            ii(0x1014_5194, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_5197, 3); lea(esi, ebp - 0xc);                    /* lea esi, [ebp-0xc] */
            ii(0x1014_519a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_519c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1014_519e, 5); calld(0x1014_5056, -0x14d);             /* call 0x10145056 */
            ii(0x1014_51a3, 5); calld(Definitions.my_strobj_c_str_v2, -0xb_b9e0); /* call 0x100897c8 */
            ii(0x1014_51a8, 5); calld(/* sys */ 0x1018_0f20, 0x3_bd73); /* call 0x10180f20 */
            ii(0x1014_51ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_51af, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_51b2, 5); calld(Definitions.my_string_dtor, -0x368d); /* call 0x10141b2a */
            ii(0x1014_51b7, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1014_51bc, 5); calld(Definitions.sys_exit, 0x2_749e);  /* call 0x1016c65f */
            ii(0x1014_51c1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_51c3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_51c4, 1); popd(edi);                              /* pop edi */
            ii(0x1014_51c5, 1); popd(esi);                              /* pop esi */
            ii(0x1014_51c6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_51c7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_51c8, 1); retd(); return;                         /* ret */
        }
    }
}
