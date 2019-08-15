using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("29d397ac-40e3-4c62-8f6d-2109da03f154")]
        public void Method_1008_d901()
        {
            ii(0x1008_d901, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1008_d906, 5); calld(Definitions.sys_check_available_stack_size, 0xd_8447); /* call 0x10165d52 */
            ii(0x1008_d90b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_d90c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_d90d, 1); pushd(edx);                             /* push edx */
            ii(0x1008_d90e, 1); pushd(esi);                             /* push esi */
            ii(0x1008_d90f, 1); pushd(edi);                             /* push edi */
            ii(0x1008_d910, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_d911, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_d913, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_d919, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_d91c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d91e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d921, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d924, 5); calld(0x1013_ad11, 0xa_d3e8);           /* call 0x1013ad11 */
            ii(0x1008_d929, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d92b, 2); if(jzd(0x1008_d960, 0x33)) goto l_0x1008_d960; /* jz 0x1008d960 */
            ii(0x1008_d92d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d930, 4); cmp(memb_a32[ds, eax + 0x25], 0x3);     /* cmp byte [eax+0x25], 0x3 */
            ii(0x1008_d934, 2); if(jzd(0x1008_d93f, 0x9)) goto l_0x1008_d93f; /* jz 0x1008d93f */
            ii(0x1008_d936, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d939, 4); cmp(memb_a32[ds, eax + 0x25], 0x9);     /* cmp byte [eax+0x25], 0x9 */
            ii(0x1008_d93d, 2); if(jld(0x1008_d941, 0x2)) goto l_0x1008_d941; /* jl 0x1008d941 */
        l_0x1008_d93f:
            ii(0x1008_d93f, 2); jmpd(0x1008_d951, 0x10); goto l_0x1008_d951; /* jmp 0x1008d951 */
        l_0x1008_d941:
            ii(0x1008_d941, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d944, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_d947, 5); calld(0x1007_6b90, -0x1_6dbc);          /* call 0x10076b90 */
            ii(0x1008_d94c, 1); cwde();                                 /* cwde */
            ii(0x1008_d94d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_d94f, 2); if(jzd(0x1008_d953, 0x2)) goto l_0x1008_d953; /* jz 0x1008d953 */
        l_0x1008_d951:
            ii(0x1008_d951, 2); jmpd(0x1008_d95b, 0x8); goto l_0x1008_d95b; /* jmp 0x1008d95b */
        l_0x1008_d953:
            ii(0x1008_d953, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d956, 5); calld(0x1008_d232, -0x729);             /* call 0x1008d232 */
        l_0x1008_d95b:
            ii(0x1008_d95b, 5); if(jmpd_func(0x1008_db55, 0x1f5)) return; /* jmp 0x1008db55 */
        l_0x1008_d960:
            ii(0x1008_d960, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d963, 3); mov(al, memb_a32[ds, eax + 0x25]);      /* mov al, [eax+0x25] */
            ii(0x1008_d966, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_d969, 5); if(jmpd_func(0x1008_db38, 0x1ca)) return; /* jmp 0x1008db38 */
        }
    }
}
