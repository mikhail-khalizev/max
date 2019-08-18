using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_58f2-ac318586")]
        public void Method_1014_58f2()
        {
            ii(0x1014_58f2, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_58f7, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0456); /* call 0x10165d52 */
            ii(0x1014_58fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_58fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_58fe, 1); pushd(esi);                             /* push esi */
            ii(0x1014_58ff, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5900, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5901, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5903, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_5909, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_590c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_590f, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_5913, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5916, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_5919, 5); calld(0x1014_581c, -0x102);             /* call 0x1014581c */
            ii(0x1014_591e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_5921, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_5925, 2); if(jnzd(0x1014_5930, 0x9)) goto l_0x1014_5930; /* jnz 0x10145930 */
            ii(0x1014_5927, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1014_592e, 2); jmpd(0x1014_593b, 0xb); goto l_0x1014_593b; /* jmp 0x1014593b */
        l_0x1014_5930:
            ii(0x1014_5930, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5933, 5); calld(0x1014_7c48, 0x2310);             /* call 0x10147c48 */
            ii(0x1014_5938, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1014_593b:
            ii(0x1014_593b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_593e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5940, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5941, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5942, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5943, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5944, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5945, 1); retd(); return;                         /* ret */
        }
    }
}
