using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("80858fe9-2612-4ab5-83c8-39b02957380e")]
        public void Method_1013_6c02()
        {
            ii(0x1013_6c02, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1013_6c07, 5); calld(Definitions.sys_check_available_stack_size, 0x2f146); /* call 0x10165d52 */
            ii(0x1013_6c0c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6c0d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6c0e, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6c0f, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6c10, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6c11, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6c13, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1013_6c19, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_6c1c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_6c1f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6c22, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_6c25, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1013_6c27, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6c2a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_6c2c, 3); mov(memd_a32[ss, ebp - 0x22], eax);     /* mov [ebp-0x22], eax */
            ii(0x1013_6c2f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6c32, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1013_6c35, 3); mov(memd_a32[ss, ebp - 0x1e], eax);     /* mov [ebp-0x1e], eax */
            ii(0x1013_6c38, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6c3b, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1013_6c3f, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x1013_6c43, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6c46, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1013_6c49, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1013_6c4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6c4f, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1013_6c52, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1013_6c55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6c58, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1013_6c5b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_6c5e, 3); add(eax, memd_a32[ds, edx + 0xc]);      /* add eax, [edx+0xc] */
            ii(0x1013_6c61, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1013_6c64, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6c67, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1013_6c6a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_6c6d, 3); add(eax, memd_a32[ds, edx + 0x10]);     /* add eax, [edx+0x10] */
            ii(0x1013_6c70, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_6c73, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x1013_6c78, 5); calld(Definitions.sys_new, 0x2f183);    /* call 0x10165e00 */
            ii(0x1013_6c7d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_6c80, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_6c83, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_6c86, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_6c8a, 2); if(jzd(0x1013_6cd1, 0x45)) goto l_0x1013_6cd1; /* jz 0x10136cd1 */
            ii(0x1013_6c8c, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_6c91, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6c92, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_6c97, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6c98, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1013_6c9d, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6c9e, 5); mov(eax, 0x8f);                         /* mov eax, 0x8f */
            ii(0x1013_6ca3, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6ca4, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1013_6ca9, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6caa, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x1013_6caf, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6cb0, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1013_6cb5, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1013_6cb8, 3); add(ebx, 0x2f);                         /* add ebx, 0x2f */
            ii(0x1013_6cbb, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1013_6cbe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_6cc1, 5); calld(0x100e_af58, -0x4bd6e);           /* call 0x100eaf58 */
            ii(0x1013_6cc6, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_6cc9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_6ccc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_6ccf, 2); jmpd(0x1013_6cd7, 0x6); goto l_0x1013_6cd7; /* jmp 0x10136cd7 */
        l_0x1013_6cd1:
            ii(0x1013_6cd1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_6cd4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1013_6cd7:
            ii(0x1013_6cd7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_6cda, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_6cdd, 3); mov(memd_a32[ds, edx + 0x4f], eax);     /* mov [edx+0x4f], eax */
            ii(0x1013_6ce0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6ce3, 3); mov(eax, memd_a32[ds, eax + 0x4f]);     /* mov eax, [eax+0x4f] */
            ii(0x1013_6ce6, 5); calld(0x100e_b180, -0x4bb6b);           /* call 0x100eb180 */
            ii(0x1013_6ceb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6ced, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6cf0, 3); mov(eax, memd_a32[ds, eax + 0x4f]);     /* mov eax, [eax+0x4f] */
            ii(0x1013_6cf3, 5); calld(0x100e_b5e1, -0x4b717);           /* call 0x100eb5e1 */
            ii(0x1013_6cf8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6cfa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_6cfb, 1); popd(edi);                              /* pop edi */
            ii(0x1013_6cfc, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6cfd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6cfe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6cff, 1); retd(); return;                         /* ret */
        }
    }
}