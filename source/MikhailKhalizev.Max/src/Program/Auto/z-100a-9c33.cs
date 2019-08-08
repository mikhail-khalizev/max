using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d5f4dfda-3451-4944-9712-6cca3fd772b1")]
        public void Method_100a_9c33()
        {
            ii(0x100a_9c33, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_9c38, 5); calld(Definitions.sys_check_available_stack_size, 0xb_c115); /* call 0x10165d52 */
            ii(0x100a_9c3d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_9c3e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_9c3f, 1); pushd(edx);                             /* push edx */
            ii(0x100a_9c40, 1); pushd(esi);                             /* push esi */
            ii(0x100a_9c41, 1); pushd(edi);                             /* push edi */
            ii(0x100a_9c42, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_9c43, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9c45, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_9c4b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_9c4e, 5); calld(0x100a_8ae1, -0x1172);            /* call 0x100a8ae1 */
            ii(0x100a_9c53, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_9c5a, 2); jmpd(0x100a_9c62, 0x6); goto l_0x100a_9c62; /* jmp 0x100a9c62 */
        l_0x100a_9c5c:
            ii(0x100a_9c5c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_9c5f, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100a_9c62:
            ii(0x100a_9c62, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_9c66, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_9c69, 2); if(jged(0x100a_9ca0, 0x35)) goto l_0x100a_9ca0; /* jge 0x100a9ca0 */
            ii(0x100a_9c6b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_9c6f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_9c75, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_9c7b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_9c80, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_9c83, 2); if(jnzd(0x100a_9c9e, 0x19)) goto l_0x100a_9c9e; /* jnz 0x100a9c9e */
            ii(0x100a_9c85, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_9c88, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_9c8c, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_9c92, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_9c97, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_9c99, 5); calld(0x100c_60d2, 0x1_c434);           /* call 0x100c60d2 */
        l_0x100a_9c9e:
            ii(0x100a_9c9e, 2); jmpd(0x100a_9c5c, -0x44); goto l_0x100a_9c5c; /* jmp 0x100a9c5c */
        l_0x100a_9ca0:
            ii(0x100a_9ca0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9ca2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_9ca3, 1); popd(edi);                              /* pop edi */
            ii(0x100a_9ca4, 1); popd(esi);                              /* pop esi */
            ii(0x100a_9ca5, 1); popd(edx);                              /* pop edx */
            ii(0x100a_9ca6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_9ca7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_9ca8, 1); retd(); return;                         /* ret */
        }
    }
}
