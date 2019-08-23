using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f017-c6ef6192")]
        public void Method_1014_f017()
        {
            ii(0x1014_f017, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_f01c, 5); calld(Definitions.sys_check_available_stack_size, 0x1_6d31); /* call 0x10165d52 */
            ii(0x1014_f021, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_f022, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_f023, 1); pushd(esi);                             /* push esi */
            ii(0x1014_f024, 1); pushd(edi);                             /* push edi */
            ii(0x1014_f025, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_f026, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_f028, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_f02e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_f031, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1014_f034, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_f036, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f039, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_f03c, 5); calld(0x1007_6a34, -0xd_860d);          /* call 0x10076a34 */
            ii(0x1014_f041, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f044, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1e);    /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1014_f048, 2); if(jnzd(0x1014_f053, 0x9)) goto l_0x1014_f053; /* jnz 0x1014f053 */
            ii(0x1014_f04a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f04d, 4); cmp(memb_a32[ds, eax + 0x3e], 0x2a);    /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1014_f051, 2); if(jnzd(0x1014_f05a, 0x7)) goto l_0x1014_f05a; /* jnz 0x1014f05a */
        l_0x1014_f053:
            ii(0x1014_f053, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f056, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
        l_0x1014_f05a:
            ii(0x1014_f05a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f05d, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1014_f061, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1014_f066, 5); calld(0x1007_5fdc, -0xd_908f);          /* call 0x10075fdc */
            ii(0x1014_f06b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_f06d, 2); if(jnzd(0x1014_f076, 0x7)) goto l_0x1014_f076; /* jnz 0x1014f076 */
            ii(0x1014_f06f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f072, 4); mov(memb_a32[ds, eax + 0x59], 0x1);     /* mov byte [eax+0x59], 0x1 */
        l_0x1014_f076:
            ii(0x1014_f076, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_f078, 3); mov(dl, memb_a32[ss, ebp - 0x4]);       /* mov dl, [ebp-0x4] */
            ii(0x1014_f07b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_f07e, 5); calld(0x1014_eea8, -0x1db);             /* call 0x1014eea8 */
            ii(0x1014_f083, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_f085, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_f086, 1); popd(edi);                              /* pop edi */
            ii(0x1014_f087, 1); popd(esi);                              /* pop esi */
            ii(0x1014_f088, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_f089, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_f08a, 1); retd();                                 /* ret */
        }
    }
}
