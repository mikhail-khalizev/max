using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5c5f-7a5d135d")]
        public void Method_1011_5c5f()
        {
            ii(0x1011_5c5f, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_5c64, 5); calld(Definitions.sys_check_available_stack_size, 0x5_00e9); /* call 0x10165d52 */
            ii(0x1011_5c69, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_5c6a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_5c6b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_5c6c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_5c6d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_5c6e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5c70, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_5c76, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_5c79, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_5c7c, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1011_5c81, 5); calld(Definitions.sys_new, 0x5_017a);   /* call 0x10165e00 */
            ii(0x1011_5c86, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_5c89, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_5c8c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_5c8f, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1011_5c93, 2); if(jzd(0x1011_5caf, 0x1a)) goto l_0x1011_5caf; /* jz 0x10115caf */
            ii(0x1011_5c95, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1011_5c99, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_5c9c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_5c9f, 5); calld(0x1011_7635, 0x1991);             /* call 0x10117635 */
            ii(0x1011_5ca4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_5ca7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_5caa, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_5cad, 2); jmpd(0x1011_5cb5, 0x6); goto l_0x1011_5cb5; /* jmp 0x10115cb5 */
        l_0x1011_5caf:
            ii(0x1011_5caf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_5cb2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1011_5cb5:
            ii(0x1011_5cb5, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1011_5cb8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5cba, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5cbf, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_5cc2, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5cc7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_5cc9, 5); calld(0x1011_7c3c, 0x1f6e);             /* call 0x10117c3c */
            ii(0x1011_5cce, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5cd0, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5cd5, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1011_5cd8, 5); mov(eax, 0x101c_52bc);                  /* mov eax, 0x101c52bc */
            ii(0x1011_5cdd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_5cdf, 5); calld(0x1007_6b90, -0x9_f154);          /* call 0x10076b90 */
            ii(0x1011_5ce4, 1); cwde();                                 /* cwde */
            ii(0x1011_5ce5, 3); cmp(eax, 0x32);                         /* cmp eax, 0x32 */
            ii(0x1011_5ce8, 2); if(jled(0x1011_5d1b, 0x31)) goto l_0x1011_5d1b; /* jle 0x10115d1b */
            ii(0x1011_5cea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5cec, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5cf1, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_5cf4, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5cf9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_5cfb, 5); calld(0x1011_7c6c, 0x1f6c);             /* call 0x10117c6c */
            ii(0x1011_5d00, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_5d02, 6); mov(bl, memb_a32[ds, 0x101c_37da]);     /* mov bl, [0x101c37da] */
            ii(0x1011_5d08, 3); imul(edx, ebx, 0xa);                    /* imul edx, ebx, 0xa */
            ii(0x1011_5d0b, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5d10, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1011_5d12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_5d14, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_5d16, 5); calld(0x1011_7c0c, 0x1ef1);             /* call 0x10117c0c */
        l_0x1011_5d1b:
            ii(0x1011_5d1b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_5d1d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5d1e, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5d1f, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5d20, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_5d21, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_5d22, 1); retd(); return;                         /* ret */
        }
    }
}
