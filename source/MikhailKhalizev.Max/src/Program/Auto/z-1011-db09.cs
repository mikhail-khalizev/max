using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6c2b7bab-355a-4dca-bf85-e0d3e279b958")]
        public void Method_1011_db09()
        {
            ii(0x1011_db09, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_db0e, 5); calld(Definitions.sys_check_available_stack_size, 0x4_823f); /* call 0x10165d52 */
            ii(0x1011_db13, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_db14, 1); pushd(esi);                             /* push esi */
            ii(0x1011_db15, 1); pushd(edi);                             /* push edi */
            ii(0x1011_db16, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_db17, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_db19, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_db1f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_db22, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_db25, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_db28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_db2b, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_db2e, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_db31, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_db34, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x1011_db37, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_db39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_db3c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_db3e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_db41, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_db43, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_db45, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
        l_0x1011_db48:
            ii(0x1011_db48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_db4b, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1011_db4f, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1011_db53, 2); if(jged(0x1011_db67, 0x12)) goto l_0x1011_db67; /* jge 0x1011db67 */
            ii(0x1011_db55, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_db58, 3); test(memb_a32[ds, eax], 0x1f);          /* test byte [eax], 0x1f */
            ii(0x1011_db5b, 2); if(jzd(0x1011_db65, 0x8)) goto l_0x1011_db65; /* jz 0x1011db65 */
            ii(0x1011_db5d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_db60, 3); test(memb_a32[ds, eax], 0x20);          /* test byte [eax], 0x20 */
            ii(0x1011_db63, 2); if(jzd(0x1011_db67, 0x2)) goto l_0x1011_db67; /* jz 0x1011db67 */
        l_0x1011_db65:
            ii(0x1011_db65, 2); jmpd(0x1011_db69, 0x2); goto l_0x1011_db69; /* jmp 0x1011db69 */
        l_0x1011_db67:
            ii(0x1011_db67, 2); jmpd(0x1011_db78, 0xf); goto l_0x1011_db78; /* jmp 0x1011db78 */
        l_0x1011_db69:
            ii(0x1011_db69, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_db6c, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1011_db6f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_db72, 4); inc(memw_a32[ds, eax + 0x2]);           /* inc word [eax+0x2] */
            ii(0x1011_db76, 2); jmpd(0x1011_db48, -0x30); goto l_0x1011_db48; /* jmp 0x1011db48 */
        l_0x1011_db78:
            ii(0x1011_db78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_db7b, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1011_db7f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_db82, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_db85, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_db87, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_db88, 1); popd(edi);                              /* pop edi */
            ii(0x1011_db89, 1); popd(esi);                              /* pop esi */
            ii(0x1011_db8a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_db8b, 1); retd(); return;                         /* ret */
        }
    }
}