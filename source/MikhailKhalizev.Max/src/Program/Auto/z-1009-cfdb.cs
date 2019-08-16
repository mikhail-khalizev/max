using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0096b809-b191-4c58-a9c0-6713f94f8b6f")]
        public void Method_1009_cfdb()
        {
            ii(0x1009_cfdb, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_cfe0, 5); calld(Definitions.sys_check_available_stack_size, 0xc_8d6d); /* call 0x10165d52 */
            ii(0x1009_cfe5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_cfe6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_cfe7, 1); pushd(esi);                             /* push esi */
            ii(0x1009_cfe8, 1); pushd(edi);                             /* push edi */
            ii(0x1009_cfe9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_cfea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cfec, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_cff2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_cff5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_cff8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_cffb, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_cffe, 5); calld(0x1007_6b90, -0x2_6473);          /* call 0x10076b90 */
            ii(0x1009_d003, 1); cwde();                                 /* cwde */
            ii(0x1009_d004, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_d006, 2); if(jgd(0x1009_d015, 0xd)) goto l_0x1009_d015; /* jg 0x1009d015 */
            ii(0x1009_d008, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_d00b, 3); mov(eax, memd_a32[ds, eax + 0x1f]);     /* mov eax, [eax+0x1f] */
            ii(0x1009_d00e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_d011, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_d013, 2); if(jled(0x1009_d02b, 0x16)) goto l_0x1009_d02b; /* jle 0x1009d02b */
        l_0x1009_d015:
            ii(0x1009_d015, 5); calld(0x1008_a79c, -0x1_287e);          /* call 0x1008a79c */
            ii(0x1009_d01a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_d01c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_d01e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_d021, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_d026, 5); calld(0x100a_53ac, 0x8381);             /* call 0x100a53ac */
        l_0x1009_d02b:
            ii(0x1009_d02b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d02d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_d02e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_d02f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_d030, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_d031, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_d032, 1); retd(); return;                         /* ret */
        }
    }
}