using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8f9f012a-d9d6-4b4b-9787-5b7a0c2086ac")]
        public void Method_1009_0aaa()
        {
            ii(0x1009_0aaa, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1009_0aaf, 5); calld(Definitions.sys_check_available_stack_size, 0xd_529e); /* call 0x10165d52 */
            ii(0x1009_0ab4, 1); pushd(esi);                             /* push esi */
            ii(0x1009_0ab5, 1); pushd(edi);                             /* push edi */
            ii(0x1009_0ab6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_0ab7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0ab9, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_0abf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_0ac2, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_0ac5, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_0ac8, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1009_0acb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0acd, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_0ad1, 5); calld(0x1007_6e7c, -0x1_9c5a);          /* call 0x10076e7c */
            ii(0x1009_0ad6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_0ad9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0adb, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1009_0adf, 5); calld(0x1007_6e7c, -0x1_9c68);          /* call 0x10076e7c */
            ii(0x1009_0ae4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_0ae7, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1009_0aed, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_0af0, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1009_0af4, 5); calld(Definitions.my_min, -0x7375);     /* call 0x10089784 */
            ii(0x1009_0af9, 3); mov(memd_a32[ss, ebp + 0x10], eax);     /* mov [ebp+0x10], eax */
            ii(0x1009_0afc, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x1009_0b02, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_0b05, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1009_0b09, 5); calld(Definitions.my_min, -0x738a);     /* call 0x10089784 */
            ii(0x1009_0b0e, 3); mov(memd_a32[ss, ebp + 0x14], eax);     /* mov [ebp+0x14], eax */
            ii(0x1009_0b11, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_0b15, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_0b18, 3); add(memd_a32[ss, ebp - 0xc], eax);      /* add [ebp-0xc], eax */
            ii(0x1009_0b1b, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1009_0b1e, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_0b21, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1009_0b24:
            ii(0x1009_0b24, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x1009_0b27, 5); cmp(memw_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x1009_0b2c, 2); if(jzd(0x1009_0b6b, 0x3d)) goto l_0x1009_0b6b; /* jz 0x10090b6b */
            ii(0x1009_0b2e, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1009_0b32, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_0b34, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_0b36, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_0b39, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_0b3b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_0b3d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_0b40, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1009_0b43, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1009_0b46, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1009_0b49:
            ii(0x1009_0b49, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
            ii(0x1009_0b4c, 5); cmp(memw_a32[ss, ebp - 0x14], -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x1009_0b51, 2); if(jzd(0x1009_0b62, 0xf)) goto l_0x1009_0b62; /* jz 0x10090b62 */
            ii(0x1009_0b53, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1009_0b56, 4); add(memd_a32[ss, ebp - 0x1c], 0x2);     /* add dword [ebp-0x1c], 0x2 */
            ii(0x1009_0b5a, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1009_0b5d, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1009_0b60, 2); jmpd(0x1009_0b49, -0x19); goto l_0x1009_0b49; /* jmp 0x10090b49 */
        l_0x1009_0b62:
            ii(0x1009_0b62, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_0b65, 4); add(memd_a32[ss, ebp - 0xc], 0x4);      /* add dword [ebp-0xc], 0x4 */
            ii(0x1009_0b69, 2); jmpd(0x1009_0b24, -0x47); goto l_0x1009_0b24; /* jmp 0x10090b24 */
        l_0x1009_0b6b:
            ii(0x1009_0b6b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_0b6d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_0b6e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_0b6f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_0b70, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
