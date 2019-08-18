using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("15f20485-e336-451a-b6d0-95e65e5ccac5")]
        public void Method_100a_cad1()
        {
            ii(0x100a_cad1, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_cad6, 5); calld(Definitions.sys_check_available_stack_size, 0xb_9277); /* call 0x10165d52 */
            ii(0x100a_cadb, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_cadc, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_cadd, 1); pushd(esi);                             /* push esi */
            ii(0x100a_cade, 1); pushd(edi);                             /* push edi */
            ii(0x100a_cadf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_cae0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_cae2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_cae8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_caeb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_caee, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_caf1, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100a_caf4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_caf7, 5); calld(0x1007_6d98, -0x3_5d64);          /* call 0x10076d98 */
            ii(0x100a_cafc, 2); test(al, al);                           /* test al, al */
            ii(0x100a_cafe, 2); if(jzd(0x100a_cb0d, 0xd)) goto l_0x100a_cb0d; /* jz 0x100acb0d */
            ii(0x100a_cb00, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cb03, 5); calld(0x1015_26ac, 0xa_5ba4);           /* call 0x101526ac */
            ii(0x100a_cb08, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x100a_cb0b, 2); if(jzd(0x100a_cb0f, 0x2)) goto l_0x100a_cb0f; /* jz 0x100acb0f */
        l_0x100a_cb0d:
            ii(0x100a_cb0d, 2); jmpd(0x100a_cb24, 0x15); goto l_0x100a_cb24; /* jmp 0x100acb24 */
        l_0x100a_cb0f:
            ii(0x100a_cb0f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_cb14, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_cb17, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cb1a, 5); calld(0x1007_65d0, -0x3_654f);          /* call 0x100765d0 */
            ii(0x100a_cb1f, 5); calld(0x100a_297d, -0xa1a7);            /* call 0x100a297d */
        l_0x100a_cb24:
            ii(0x100a_cb24, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_cb26, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_cb27, 1); popd(edi);                              /* pop edi */
            ii(0x100a_cb28, 1); popd(esi);                              /* pop esi */
            ii(0x100a_cb29, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_cb2a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_cb2b, 1); retd(); return;                         /* ret */
        }
    }
}
