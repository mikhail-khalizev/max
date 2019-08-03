using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a2622891-07e1-4d9a-9d2c-5456e6c97203")]
        public void Method_1015_0369()
        {
            ii(0x1015_0369, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1015_036e, 5); calld(Definitions.sys_check_available_stack_size, 0x159df); /* call 0x10165d52 */
            ii(0x1015_0373, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_0374, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_0375, 1); pushd(edx);                             /* push edx */
            ii(0x1015_0376, 1); pushd(esi);                             /* push esi */
            ii(0x1015_0377, 1); pushd(edi);                             /* push edi */
            ii(0x1015_0378, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_0379, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_037b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_0381, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_0384, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0387, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1015_038a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_038d, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1015_0390, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_0393, 3); fild(memd_a32[ss, ebp - 0x10]);         /* fild dword [ebp-0x10] */
            ii(0x1015_0396, 5); calld(Definitions.sys_sqrt, 0x15cab);   /* call 0x10166046 */
            ii(0x1015_039b, 6); fadd(memq_a32[ds, 0x101a_dde9]);        /* fadd qword [0x101adde9] */
            ii(0x1015_03a1, 5); calld(Definitions.sys_round, 0x15cd8);  /* call 0x1016607e */
            ii(0x1015_03a6, 3); fistp(memd_a32[ss, ebp - 0x10]);        /* fistp dword [ebp-0x10] */
            ii(0x1015_03a9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_03ac, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_03af, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1015_03b3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_03b5, 2); if(jged(0x1015_03be, 0x7)) goto l_0x1015_03be; /* jge 0x101503be */
            ii(0x1015_03b7, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1015_03be:
            ii(0x1015_03be, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_03c1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_03c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_03c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_03c9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_03ca, 1); popd(edi);                              /* pop edi */
            ii(0x1015_03cb, 1); popd(esi);                              /* pop esi */
            ii(0x1015_03cc, 1); popd(edx);                              /* pop edx */
            ii(0x1015_03cd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_03ce, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_03cf, 1); retd(); return;                         /* ret */
        }
    }
}