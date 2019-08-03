using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("556afd78-f9c7-4f55-aa57-a10515b1b776")]
        public void Method_1011_6b06()
        {
            ii(0x1011_6b06, 5); pushd(0x78);                            /* push 0x78 */
            ii(0x1011_6b0b, 5); calld(Definitions.sys_check_available_stack_size, 0x4f242); /* call 0x10165d52 */
            ii(0x1011_6b10, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_6b11, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_6b12, 1); pushd(edx);                             /* push edx */
            ii(0x1011_6b13, 1); pushd(esi);                             /* push esi */
            ii(0x1011_6b14, 1); pushd(edi);                             /* push edi */
            ii(0x1011_6b15, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_6b16, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_6b18, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x1011_6b1e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_6b21, 5); calld(0x1014_82f4, 0x317ce);            /* call 0x101482f4 */
            ii(0x1011_6b26, 6); sub(eax, memd_a32[ds, 0x101c_396c]);    /* sub eax, [0x101c396c] */
            ii(0x1011_6b2c, 5); mov(ebx, 0x12_34dc);                    /* mov ebx, 0x1234dc */
            ii(0x1011_6b31, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_6b33, 2); div(ebx);                               /* div ebx */
            ii(0x1011_6b35, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_6b37, 5); mov(eax, memd_a32[ds, 0x101c_3960]);    /* mov eax, [0x101c3960] */
            ii(0x1011_6b3c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_6b3f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_6b41, 6); mov(memw_a32[ds, 0x101c_3962], ax);     /* mov [0x101c3962], ax */
            ii(0x1011_6b47, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1011_6b4b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_6b50, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_6b53, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1011_6b56, 5); calld(0x1011_61a2, -0x9b9);             /* call 0x101161a2 */
            ii(0x1011_6b5b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_6b5e, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1011_6b62, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1011_6b65, 5); calld(0x1011_6aa4, -0xc6);              /* call 0x10116aa4 */
            ii(0x1011_6b6a, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_6b71, 2); if(jzd(0x1011_6b89, 0x16)) goto l_0x1011_6b89; /* jz 0x10116b89 */
            ii(0x1011_6b73, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_6b75, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_6b77, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_6b7c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_6b7f, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1011_6b84, 5); calld(0x1012_8897, 0x11d0e);            /* call 0x10128897 */
        l_0x1011_6b89:
            ii(0x1011_6b89, 5); calld(0x1014_82f4, 0x31766);            /* call 0x101482f4 */
            ii(0x1011_6b8e, 5); mov(memd_a32[ds, 0x101c_396c], eax);    /* mov [0x101c396c], eax */
            ii(0x1011_6b93, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_6b95, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1011_6b98, 5); calld(0x1011_6536, -0x667);             /* call 0x10116536 */
            ii(0x1011_6b9d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_6b9f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_6ba0, 1); popd(edi);                              /* pop edi */
            ii(0x1011_6ba1, 1); popd(esi);                              /* pop esi */
            ii(0x1011_6ba2, 1); popd(edx);                              /* pop edx */
            ii(0x1011_6ba3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_6ba4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_6ba5, 1); retd(); return;                         /* ret */
        }
    }
}
