using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b5491549-3159-4c6c-829a-2231d171bc76")]
        public void Method_1015_1e55()
        {
            ii(0x1015_1e55, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1015_1e5a, 5); calld(Definitions.sys_check_available_stack_size, 0x1_3ef3); /* call 0x10165d52 */
            ii(0x1015_1e5f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_1e60, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_1e61, 1); pushd(esi);                             /* push esi */
            ii(0x1015_1e62, 1); pushd(edi);                             /* push edi */
            ii(0x1015_1e63, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_1e64, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_1e66, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_1e6c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_1e6f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_1e72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_1e75, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_1e78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1e7b, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1e7e, 5); calld(Definitions.my_2_get_count, -0xc_6b1b); /* call 0x1008b368 */
            ii(0x1015_1e83, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1015_1e85, 5); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1015_1e8a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_1e8d, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_1e91, 5); cmp(eax, 0x226);                        /* cmp eax, 0x226 */
            ii(0x1015_1e96, 2); if(jgd(0x1015_1ea1, 0x9)) goto l_0x1015_1ea1; /* jg 0x10151ea1 */
            ii(0x1015_1e98, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1015_1e9f, 2); jmpd(0x1015_1eba, 0x19); goto l_0x1015_1eba; /* jmp 0x10151eba */
        l_0x1015_1ea1:
            ii(0x1015_1ea1, 5); mov(ecx, 0xe1e);                        /* mov ecx, 0xe1e */
            ii(0x1015_1ea6, 5); mov(ebx, StringDefinitions.UnitinfoCpp6); /* mov ebx, 0x101adec4 */
            ii(0x1015_1eab, 5); mov(edx, StringDefinitions.SizeLessOrEqualMaxdatalen); /* mov edx, 0x101aded1 */
            ii(0x1015_1eb0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_1eb2, 5); calld(Definitions.sys_assert, 0x1_3edb); /* call 0x10165d92 */
            ii(0x1015_1eb7, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1015_1eba:
            ii(0x1015_1eba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1ebd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1ebf, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_1ec2, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1ec5, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x1015_1ec8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1ecb, 3); mov(dl, memb_a32[ds, eax + 0x3e]);      /* mov dl, [eax+0x3e] */
            ii(0x1015_1ece, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1ed1, 3); mov(memb_a32[ds, eax + 0x2], dl);       /* mov [eax+0x2], dl */
            ii(0x1015_1ed4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1ed7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1ed9, 3); mov(dl, memb_a32[ds, eax + 0x45]);      /* mov dl, [eax+0x45] */
            ii(0x1015_1edc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1edf, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x1015_1ee3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1ee6, 4); mov(dx, memw_a32[ds, eax + 0x78]);      /* mov dx, [eax+0x78] */
            ii(0x1015_1eea, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1eed, 4); mov(memw_a32[ds, eax + 0x6], dx);       /* mov [eax+0x6], dx */
            ii(0x1015_1ef1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1ef4, 4); mov(dx, memw_a32[ds, eax + 0x41]);      /* mov dx, [eax+0x41] */
            ii(0x1015_1ef8, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1efb, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1015_1eff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1f02, 4); mov(dx, memw_a32[ds, eax + 0x43]);      /* mov dx, [eax+0x43] */
            ii(0x1015_1f06, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1f09, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x1015_1f0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1f10, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1f13, 5); calld(Definitions.my_2_get_count, -0xc_6bb0); /* call 0x1008b368 */
            ii(0x1015_1f18, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_1f1a, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1f1d, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1015_1f21, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1f24, 3); mov(dl, memb_a32[ds, eax + 0x7a]);      /* mov dl, [eax+0x7a] */
            ii(0x1015_1f27, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1f2a, 3); mov(memb_a32[ds, eax + 0x3], dl);       /* mov [eax+0x3], dl */
            ii(0x1015_1f2d, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_1f30, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1015_1f33, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_1f36, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1015_1f3d, 2); jmpd(0x1015_1f45, 0x6); goto l_0x1015_1f45; /* jmp 0x10151f45 */
        l_0x1015_1f3f:
            ii(0x1015_1f3f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_1f42, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1015_1f45:
            ii(0x1015_1f45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1f48, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1f4b, 5); calld(Definitions.my_2_get_count, -0xc_6be8); /* call 0x1008b368 */
            ii(0x1015_1f50, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1015_1f54, 2); if(jled(0x1015_1f76, 0x20)) goto l_0x1015_1f76; /* jle 0x10151f76 */
            ii(0x1015_1f56, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1015_1f5a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_1f5d, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1f60, 5); calld(0x1008_b228, -0xc_6d3d);          /* call 0x1008b228 */
            ii(0x1015_1f65, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1015_1f69, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1015_1f6b, 3); add(edx, memd_a32[ss, ebp - 0x1c]);     /* add edx, [ebp-0x1c] */
            ii(0x1015_1f6e, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1015_1f71, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1015_1f74, 2); jmpd(0x1015_1f3f, -0x37); goto l_0x1015_1f3f; /* jmp 0x10151f3f */
        l_0x1015_1f76:
            ii(0x1015_1f76, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_1f79, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_1f7c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_1f7f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_1f81, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_1f82, 1); popd(edi);                              /* pop edi */
            ii(0x1015_1f83, 1); popd(esi);                              /* pop esi */
            ii(0x1015_1f84, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_1f85, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_1f86, 1); retd(); return;                         /* ret */
        }
    }
}
