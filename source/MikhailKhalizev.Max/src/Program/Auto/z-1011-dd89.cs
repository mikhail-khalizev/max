using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("96c904de-7a64-497b-be75-e0ed38f94b52")]
        public void Method_1011_dd89()
        {
            ii(0x1011_dd89, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_dd8e, 5); calld(Definitions.sys_check_available_stack_size, 0x47fbf); /* call 0x10165d52 */
            ii(0x1011_dd93, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_dd94, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_dd95, 1); pushd(edx);                             /* push edx */
            ii(0x1011_dd96, 1); pushd(esi);                             /* push esi */
            ii(0x1011_dd97, 1); pushd(edi);                             /* push edi */
            ii(0x1011_dd98, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_dd99, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_dd9b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_dda1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_dda4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dda7, 4); cmp(memd_a32[ds, eax + 0x16], 0);       /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_ddab, 2); if(jzd(0x1011_dde1, 0x34)) goto l_0x1011_dde1; /* jz 0x1011dde1 */
            ii(0x1011_ddad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ddb0, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_ddb3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_ddb6, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_ddba, 2); if(jzd(0x1011_ddd0, 0x14)) goto l_0x1011_ddd0; /* jz 0x1011ddd0 */
            ii(0x1011_ddbc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_ddbe, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_ddc1, 5); calld(Definitions.my_dtor_d7, -0x1b84); /* call 0x1011c242 */
            ii(0x1011_ddc6, 5); calld(Definitions.sys_delete, 0x48199); /* call 0x10165f64 */
            ii(0x1011_ddcb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_ddce, 2); jmpd(0x1011_ddd7, 0x7); goto l_0x1011_ddd7; /* jmp 0x1011ddd7 */
        l_0x1011_ddd0:
            ii(0x1011_ddd0, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1011_ddd7:
            ii(0x1011_ddd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ddda, 7); mov(memd_a32[ds, eax + 0x16], 0);       /* mov dword [eax+0x16], 0x0 */
        l_0x1011_dde1:
            ii(0x1011_dde1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dde4, 4); cmp(memd_a32[ds, eax + 0x1a], 0);       /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_dde8, 2); if(jzd(0x1011_de1e, 0x34)) goto l_0x1011_de1e; /* jz 0x1011de1e */
            ii(0x1011_ddea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dded, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1011_ddf0, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_ddf3, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_ddf7, 2); if(jzd(0x1011_de0d, 0x14)) goto l_0x1011_de0d; /* jz 0x1011de0d */
            ii(0x1011_ddf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_ddfb, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_ddfe, 5); calld(Definitions.my_dtor_d7, -0x1bc1); /* call 0x1011c242 */
            ii(0x1011_de03, 5); calld(Definitions.sys_delete, 0x4815c); /* call 0x10165f64 */
            ii(0x1011_de08, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_de0b, 2); jmpd(0x1011_de14, 0x7); goto l_0x1011_de14; /* jmp 0x1011de14 */
        l_0x1011_de0d:
            ii(0x1011_de0d, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_de14:
            ii(0x1011_de14, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_de17, 7); mov(memd_a32[ds, eax + 0x1a], 0);       /* mov dword [eax+0x1a], 0x0 */
        l_0x1011_de1e:
            ii(0x1011_de1e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_de20, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_de23, 5); calld(0x100b_7fa4, -0x65e84);           /* call 0x100b7fa4 */
            ii(0x1011_de28, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_de2b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_de2e, 5); calld(0x1013_a6f4, 0x1c8c1);            /* call 0x1013a6f4 */
            ii(0x1011_de33, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_de35, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_de36, 1); popd(edi);                              /* pop edi */
            ii(0x1011_de37, 1); popd(esi);                              /* pop esi */
            ii(0x1011_de38, 1); popd(edx);                              /* pop edx */
            ii(0x1011_de39, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_de3a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_de3b, 1); retd(); return;                         /* ret */
        }
    }
}
