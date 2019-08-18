using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("93837a3d-cb63-4949-9a0b-320a1ef0e61d")]
        public void Method_1011_9e3a()
        {
            ii(0x1011_9e3a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_9e3f, 5); calld(Definitions.sys_check_available_stack_size, 0x4_bf0e); /* call 0x10165d52 */
            ii(0x1011_9e44, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_9e45, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_9e46, 1); pushd(esi);                             /* push esi */
            ii(0x1011_9e47, 1); pushd(edi);                             /* push edi */
            ii(0x1011_9e48, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_9e49, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9e4b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_9e51, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_9e54, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_9e57, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_9e5b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9e5d, 2); if(jnzd(0x1011_9e7f, 0x20)) goto l_0x1011_9e7f; /* jnz 0x10119e7f */
            ii(0x1011_9e5f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_9e63, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9e65, 2); if(jged(0x1011_9e73, 0xc)) goto l_0x1011_9e73; /* jge 0x10119e73 */
            ii(0x1011_9e67, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_9e6e, 5); jmpd(0x1011_9edb, 0x68); goto l_0x1011_9edb; /* jmp 0x10119edb */
        l_0x1011_9e73:
            ii(0x1011_9e73, 7); mov(memd_a32[ss, ebp - 0xc], 0x4);      /* mov dword [ebp-0xc], 0x4 */
            ii(0x1011_9e7a, 5); jmpd(0x1011_9edb, 0x5c); goto l_0x1011_9edb; /* jmp 0x10119edb */
        l_0x1011_9e7f:
            ii(0x1011_9e7f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_9e83, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9e85, 2); if(jled(0x1011_9eb2, 0x2b)) goto l_0x1011_9eb2; /* jle 0x10119eb2 */
            ii(0x1011_9e87, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_9e8b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9e8d, 2); if(jged(0x1011_9e98, 0x9)) goto l_0x1011_9e98; /* jge 0x10119e98 */
            ii(0x1011_9e8f, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x1011_9e96, 2); jmpd(0x1011_9edb, 0x43); goto l_0x1011_9edb; /* jmp 0x10119edb */
        l_0x1011_9e98:
            ii(0x1011_9e98, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_9e9c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9e9e, 2); if(jnzd(0x1011_9ea9, 0x9)) goto l_0x1011_9ea9; /* jnz 0x10119ea9 */
            ii(0x1011_9ea0, 7); mov(memd_a32[ss, ebp - 0xc], 0x2);      /* mov dword [ebp-0xc], 0x2 */
            ii(0x1011_9ea7, 2); jmpd(0x1011_9edb, 0x32); goto l_0x1011_9edb; /* jmp 0x10119edb */
        l_0x1011_9ea9:
            ii(0x1011_9ea9, 7); mov(memd_a32[ss, ebp - 0xc], 0x3);      /* mov dword [ebp-0xc], 0x3 */
            ii(0x1011_9eb0, 2); jmpd(0x1011_9edb, 0x29); goto l_0x1011_9edb; /* jmp 0x10119edb */
        l_0x1011_9eb2:
            ii(0x1011_9eb2, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_9eb6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9eb8, 2); if(jled(0x1011_9ec3, 0x9)) goto l_0x1011_9ec3; /* jle 0x10119ec3 */
            ii(0x1011_9eba, 7); mov(memd_a32[ss, ebp - 0xc], 0x5);      /* mov dword [ebp-0xc], 0x5 */
            ii(0x1011_9ec1, 2); jmpd(0x1011_9edb, 0x18); goto l_0x1011_9edb; /* jmp 0x10119edb */
        l_0x1011_9ec3:
            ii(0x1011_9ec3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_9ec7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9ec9, 2); if(jnzd(0x1011_9ed4, 0x9)) goto l_0x1011_9ed4; /* jnz 0x10119ed4 */
            ii(0x1011_9ecb, 7); mov(memd_a32[ss, ebp - 0xc], 0x6);      /* mov dword [ebp-0xc], 0x6 */
            ii(0x1011_9ed2, 2); jmpd(0x1011_9edb, 0x7); goto l_0x1011_9edb; /* jmp 0x10119edb */
        l_0x1011_9ed4:
            ii(0x1011_9ed4, 7); mov(memd_a32[ss, ebp - 0xc], 0x7);      /* mov dword [ebp-0xc], 0x7 */
        l_0x1011_9edb:
            ii(0x1011_9edb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_9ede, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9ee0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_9ee1, 1); popd(edi);                              /* pop edi */
            ii(0x1011_9ee2, 1); popd(esi);                              /* pop esi */
            ii(0x1011_9ee3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_9ee4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_9ee5, 1); retd(); return;                         /* ret */
        }
    }
}
