using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5dcdd0f5-d3a9-4f3d-af4e-f6bac5882615")]
        public void Method_100a_8a3d()
        {
            ii(0x100a_8a3d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_8a42, 5); calld(Definitions.sys_check_available_stack_size, 0xb_d30b); /* call 0x10165d52 */
            ii(0x100a_8a47, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_8a48, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_8a49, 1); pushd(esi);                             /* push esi */
            ii(0x100a_8a4a, 1); pushd(edi);                             /* push edi */
            ii(0x100a_8a4b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_8a4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_8a4e, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_8a54, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_8a57, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_8a5a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_8a5d, 3); add(edx, 0x4e);                         /* add edx, 0x4e */
            ii(0x100a_8a60, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8a63, 5); calld(0x1007_6d98, -0x3_1cd0);          /* call 0x10076d98 */
            ii(0x100a_8a68, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8a6a, 2); if(jzd(0x100a_8a7e, 0x12)) goto l_0x100a_8a7e; /* jz 0x100a8a7e */
            ii(0x100a_8a6c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_8a6f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_8a72, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_8a75, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_8a78, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_8a7b, 3); calld_abs(memd_a32[ds, edx + 0x3c]);    /* call dword [edx+0x3c] */
        l_0x100a_8a7e:
            ii(0x100a_8a7e, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_8a82, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_8a85, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_8a87, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_8a88, 1); popd(edi);                              /* pop edi */
            ii(0x100a_8a89, 1); popd(esi);                              /* pop esi */
            ii(0x100a_8a8a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_8a8b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_8a8c, 1); retd(); return;                         /* ret */
        }
    }
}
