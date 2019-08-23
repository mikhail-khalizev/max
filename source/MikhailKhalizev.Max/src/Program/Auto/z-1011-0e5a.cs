using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_0e5a-3576bf29")]
        public void Method_1011_0e5a()
        {
            ii(0x1011_0e5a, 5); pushd(0xd8);                            /* push 0xd8 */
            ii(0x1011_0e5f, 5); calld(Definitions.sys_check_available_stack_size, 0x5_4eee); /* call 0x10165d52 */
            ii(0x1011_0e64, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_0e65, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_0e66, 1); pushd(esi);                             /* push esi */
            ii(0x1011_0e67, 1); pushd(edi);                             /* push edi */
            ii(0x1011_0e68, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_0e69, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_0e6b, 6); sub(esp, 0xc0);                         /* sub esp, 0xc0 */
            ii(0x1011_0e71, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_0e74, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_0e77, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_0e7a, 7); cmp(memb_a32[ds, eax + 0x143], 0x2);    /* cmp byte [eax+0x143], 0x2 */
            ii(0x1011_0e81, 2); if(jnzd(0x1011_0e9e, 0x1b)) goto l_0x1011_0e9e; /* jnz 0x10110e9e */
            ii(0x1011_0e83, 5); mov(eax, 0x41);                         /* mov eax, 0x41 */
            ii(0x1011_0e88, 5); calld(0x1007_5fdc, -0x9_aeb1);          /* call 0x10075fdc */
            ii(0x1011_0e8d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1011_0e91, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_0e93, 2); if(jled(0x1011_0e9e, 0x9)) goto l_0x1011_0e9e; /* jle 0x10110e9e */
            ii(0x1011_0e95, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_0e9c, 2); jmpd(0x1011_0ef1, 0x53); goto l_0x1011_0ef1; /* jmp 0x10110ef1 */
        l_0x1011_0e9e:
            ii(0x1011_0e9e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0ea1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_0ea4, 2); jmpd(0x1011_0eac, 0x6); goto l_0x1011_0eac; /* jmp 0x10110eac */
        l_0x1011_0ea6:
            ii(0x1011_0ea6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_0ea9, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1011_0eac:
            ii(0x1011_0eac, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_0eb0, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_0eb4, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_0eb7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_0eb9, 2); if(jged(0x1011_0eea, 0x2f)) goto l_0x1011_0eea; /* jge 0x10110eea */
            ii(0x1011_0ebb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_0ebd, 6); lea(ebx, ebp - 0xc0);                   /* lea ebx, [ebp-0xc0] */
            ii(0x1011_0ec3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_0ec6, 8); movsx(ax, memb_a32[ds, eax + 0x143]);   /* movsx ax, byte [eax+0x143] */
            ii(0x1011_0ece, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_0ed1, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_0ed5, 5); calld(0x1013_9ade, 0x2_8c04);           /* call 0x10139ade */
            ii(0x1011_0eda, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_0edd, 2); if(jnzd(0x1011_0ee8, 0x9)) goto l_0x1011_0ee8; /* jnz 0x10110ee8 */
            ii(0x1011_0edf, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
            ii(0x1011_0ee6, 2); jmpd(0x1011_0ef1, 0x9); goto l_0x1011_0ef1; /* jmp 0x10110ef1 */
        l_0x1011_0ee8:
            ii(0x1011_0ee8, 2); jmpd(0x1011_0ea6, -0x44); goto l_0x1011_0ea6; /* jmp 0x10110ea6 */
        l_0x1011_0eea:
            ii(0x1011_0eea, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_0ef1:
            ii(0x1011_0ef1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_0ef4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_0ef6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_0ef7, 1); popd(edi);                              /* pop edi */
            ii(0x1011_0ef8, 1); popd(esi);                              /* pop esi */
            ii(0x1011_0ef9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_0efa, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_0efb, 1); retd();                                 /* ret */
        }
    }
}
