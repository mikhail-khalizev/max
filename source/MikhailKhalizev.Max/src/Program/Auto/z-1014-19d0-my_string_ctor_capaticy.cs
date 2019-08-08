using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1842a043-c6f9-4f2f-9f1f-42c9cea3a783")]
        public void my_string_ctor_capaticy()
        {
            ii(0x1014_19d0, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_19d5, 5); calld(Definitions.sys_check_available_stack_size, 0x2_4378); /* call 0x10165d52 */
            ii(0x1014_19da, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_19db, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_19dc, 1); pushd(esi);                             /* push esi */
            ii(0x1014_19dd, 1); pushd(edi);                             /* push edi */
            ii(0x1014_19de, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_19df, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_19e1, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_19e7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_19ea, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_19ed, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1014_19f2, 5); calld(Definitions.sys_new, 0x2_4409);   /* call 0x10165e00 */
            ii(0x1014_19f7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_19fa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_19fd, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_1a00, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_1a04, 2); if(jzd(0x1014_1a1c, 0x16)) goto l_0x1014_1a1c; /* jz 0x10141a1c */
            ii(0x1014_1a06, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_1a09, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1a0c, 5); calld(Definitions.my_strobj_ctor_capaticy, -0x2de); /* call 0x10141733 */
            ii(0x1014_1a11, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_1a14, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_1a17, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_1a1a, 2); jmpd(0x1014_1a22, 0x6); goto l_0x1014_1a22; /* jmp 0x10141a22 */
        l_0x1014_1a1c:
            ii(0x1014_1a1c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_1a1f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1014_1a22:
            ii(0x1014_1a22, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1a25, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_1a28, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1014_1a2a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1a2d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_1a30, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_1a33, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1a35, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1a36, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1a37, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1a38, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1a39, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1a3a, 1); retd(); return;                         /* ret */
        }
    }
}
