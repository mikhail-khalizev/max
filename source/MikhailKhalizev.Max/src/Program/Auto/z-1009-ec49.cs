using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("716c7ed1-55ed-4658-8af0-8a98ece340a2")]
        public void Method_1009_ec49()
        {
            ii(0x1009_ec49, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_ec4e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_70ff); /* call 0x10165d52 */
            ii(0x1009_ec53, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_ec54, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ec55, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ec56, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ec57, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ec58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ec5a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ec60, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ec63, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_ec66, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_ec69, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ec6c, 5); calld(0x1015_2a52, 0xb_3de1);           /* call 0x10152a52 */
            ii(0x1009_ec71, 2); test(al, al);                           /* test al, al */
            ii(0x1009_ec73, 2); if(jnzd(0x1009_ec7b, 0x6)) goto l_0x1009_ec7b; /* jnz 0x1009ec7b */
            ii(0x1009_ec75, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_ec79, 2); jmpd(0x1009_ecad, 0x32); goto l_0x1009_ecad; /* jmp 0x1009ecad */
        l_0x1009_ec7b:
            ii(0x1009_ec7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ec7e, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1009_ec81, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_ec86, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_ec88, 2); if(jnzd(0x1009_ec90, 0x6)) goto l_0x1009_ec90; /* jnz 0x1009ec90 */
            ii(0x1009_ec8a, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_ec8e, 2); jmpd(0x1009_ecad, 0x1d); goto l_0x1009_ecad; /* jmp 0x1009ecad */
        l_0x1009_ec90:
            ii(0x1009_ec90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ec93, 5); calld(0x1007_623c, -0x2_8a5c);          /* call 0x1007623c */
            ii(0x1009_ec98, 3); mov(ebx, memd_a32[ds, eax + 0x15]);     /* mov ebx, [eax+0x15] */
            ii(0x1009_ec9b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_ec9e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_eca1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_eca4, 5); calld(0x1009_d066, -0x1c43);            /* call 0x1009d066 */
            ii(0x1009_eca9, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1009_ecad:
            ii(0x1009_ecad, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_ecb0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ecb2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ecb3, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ecb4, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ecb5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ecb6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ecb7, 1); retd(); return;                         /* ret */
        }
    }
}
