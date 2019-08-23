using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_7aaa-3329c4e2")]
        public void Method_1015_7aaa()
        {
            ii(0x1015_7aaa, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1015_7aaf, 5); calld(Definitions.sys_check_available_stack_size, 0xe29e); /* call 0x10165d52 */
            ii(0x1015_7ab4, 1); pushd(esi);                             /* push esi */
            ii(0x1015_7ab5, 1); pushd(edi);                             /* push edi */
            ii(0x1015_7ab6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_7ab7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_7ab9, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1015_7abf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_7ac2, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1015_7ac5, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1015_7ac8, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1015_7acb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_7ace, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7ad1, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1015_7ad3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7ad6, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7ad9, 4); mov(memw_a32[ds, edx + 0x27], ax);      /* mov [edx+0x27], ax */
            ii(0x1015_7add, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_7ae0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7ae3, 4); mov(memw_a32[ds, edx + 0x29], ax);      /* mov [edx+0x29], ax */
            ii(0x1015_7ae7, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1015_7aea, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7aed, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x1015_7af1, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1015_7af4, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7af7, 4); mov(memw_a32[ds, edx + 0xa], ax);       /* mov [edx+0xa], ax */
            ii(0x1015_7afb, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1015_7afe, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b01, 4); mov(memw_a32[ds, edx + 0xc], ax);       /* mov [edx+0xc], ax */
            ii(0x1015_7b05, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1015_7b08, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b0b, 4); mov(memw_a32[ds, edx + 0xe], ax);       /* mov [edx+0xe], ax */
            ii(0x1015_7b0f, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
            ii(0x1015_7b12, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b15, 4); mov(memw_a32[ds, edx + 0x10], ax);      /* mov [edx+0x10], ax */
            ii(0x1015_7b19, 3); mov(eax, memd_a32[ss, ebp + 0x24]);     /* mov eax, [ebp+0x24] */
            ii(0x1015_7b1c, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b1f, 4); mov(memw_a32[ds, edx + 0x12], ax);      /* mov [edx+0x12], ax */
            ii(0x1015_7b23, 3); mov(al, memb_a32[ss, ebp + 0x28]);      /* mov al, [ebp+0x28] */
            ii(0x1015_7b26, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b29, 3); mov(memb_a32[ds, edx + 0x14], al);      /* mov [edx+0x14], al */
            ii(0x1015_7b2c, 3); mov(eax, memd_a32[ss, ebp + 0x34]);     /* mov eax, [ebp+0x34] */
            ii(0x1015_7b2f, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b32, 3); mov(memd_a32[ds, edx + 0x17], eax);     /* mov [edx+0x17], eax */
            ii(0x1015_7b35, 3); mov(eax, memd_a32[ss, ebp + 0x38]);     /* mov eax, [ebp+0x38] */
            ii(0x1015_7b38, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b3b, 3); mov(memd_a32[ds, edx + 0x1b], eax);     /* mov [edx+0x1b], eax */
            ii(0x1015_7b3e, 3); mov(eax, memd_a32[ss, ebp + 0x3c]);     /* mov eax, [ebp+0x3c] */
            ii(0x1015_7b41, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b44, 3); mov(memd_a32[ds, edx + 0x1f], eax);     /* mov [edx+0x1f], eax */
            ii(0x1015_7b47, 3); mov(al, memb_a32[ss, ebp + 0x2c]);      /* mov al, [ebp+0x2c] */
            ii(0x1015_7b4a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b4d, 3); mov(memb_a32[ds, edx + 0x15], al);      /* mov [edx+0x15], al */
            ii(0x1015_7b50, 3); mov(eax, memd_a32[ss, ebp + 0x40]);     /* mov eax, [ebp+0x40] */
            ii(0x1015_7b53, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7b56, 3); mov(memd_a32[ds, edx + 0x23], eax);     /* mov [edx+0x23], eax */
            ii(0x1015_7b59, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7b5b, 3); mov(al, memb_a32[ss, ebp + 0x30]);      /* mov al, [ebp+0x30] */
            ii(0x1015_7b5e, 5); calld(Definitions.sys_tolower, 0x1_af32); /* call 0x10172a95 */
            ii(0x1015_7b63, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_7b66, 5); jmpd(0x1015_7bef, 0x84); goto l_0x1015_7bef; /* jmp 0x10157bef */
        l_0x1015_7b6b:
            ii(0x1015_7b6b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_7b6e, 4); mov(memb_a32[ds, eax + 0x16], 0);       /* mov byte [eax+0x16], 0x0 */
            ii(0x1015_7b72, 5); jmpd(0x1015_7c1a, 0xa3); goto l_0x1015_7c1a; /* jmp 0x10157c1a */
        l_0x1015_7b77:
            ii(0x1015_7b77, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_7b7a, 4); mov(memb_a32[ds, eax + 0x16], 0x1);     /* mov byte [eax+0x16], 0x1 */
            ii(0x1015_7b7e, 5); jmpd(0x1015_7c1a, 0x97); goto l_0x1015_7c1a; /* jmp 0x10157c1a */
        l_0x1015_7b83:
            ii(0x1015_7b83, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_7b86, 4); mov(memb_a32[ds, eax + 0x16], 0x2);     /* mov byte [eax+0x16], 0x2 */
            ii(0x1015_7b8a, 5); jmpd(0x1015_7c1a, 0x8b); goto l_0x1015_7c1a; /* jmp 0x10157c1a */
        l_0x1015_7b8f:
            ii(0x1015_7b8f, 4); cmp(memb_a32[ss, ebp + 0x30], 0x4d);    /* cmp byte [ebp+0x30], 0x4d */
            ii(0x1015_7b93, 2); if(jzd(0x1015_7b9b, 0x6)) goto l_0x1015_7b9b; /* jz 0x10157b9b */
            ii(0x1015_7b95, 4); cmp(memb_a32[ss, ebp + 0x30], 0x46);    /* cmp byte [ebp+0x30], 0x46 */
            ii(0x1015_7b99, 2); if(jnzd(0x1015_7b9d, 0x2)) goto l_0x1015_7b9d; /* jnz 0x10157b9d */
        l_0x1015_7b9b:
            ii(0x1015_7b9b, 2); jmpd(0x1015_7ba3, 0x6); goto l_0x1015_7ba3; /* jmp 0x10157ba3 */
        l_0x1015_7b9d:
            ii(0x1015_7b9d, 4); cmp(memb_a32[ss, ebp + 0x30], 0x46);    /* cmp byte [ebp+0x30], 0x46 */
            ii(0x1015_7ba1, 2); if(jnzd(0x1015_7ba5, 0x2)) goto l_0x1015_7ba5; /* jnz 0x10157ba5 */
        l_0x1015_7ba3:
            ii(0x1015_7ba3, 2); jmpd(0x1015_7bed, 0x48); goto l_0x1015_7bed; /* jmp 0x10157bed */
        l_0x1015_7ba5:
            ii(0x1015_7ba5, 5); mov(ecx, 0x658);                        /* mov ecx, 0x658 */
            ii(0x1015_7baa, 5); mov(ebx, StringDefinitions.UnitsmgrCpp4); /* mov ebx, 0x101b239f */
            ii(0x1015_7baf, 3); mov(eax, memd_a32[ss, ebp + 0x34]);     /* mov eax, [ebp+0x34] */
            ii(0x1015_7bb2, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7bb3, 5); mov(eax, StringDefinitions.IncorrectGenderForS); /* mov eax, 0x101b23ac */
            ii(0x1015_7bb8, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7bb9, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1015_7bbe, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7bbf, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_7bc2, 5); calld(Definitions.my_string_ctor, -0x1_60df); /* call 0x10141ae8 */
            ii(0x1015_7bc7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_7bc8, 5); calld(0x1014_2037, -0x1_5b96);          /* call 0x10142037 */
            ii(0x1015_7bcd, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1015_7bd0, 5); calld(Definitions.my_strobj_c_str_v2, -0xc_e40d); /* call 0x100897c8 */
            ii(0x1015_7bd5, 5); mov(esi, StringDefinitions.NewGenderEqualMNewGenderEqualFNewGenderEqualF); /* mov esi, 0x101b23c4 */
            ii(0x1015_7bda, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_7bdc, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1015_7bde, 5); calld(0x100f_07d4, -0x6_740f);          /* call 0x100f07d4 */
            ii(0x1015_7be3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_7be5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_7be8, 5); calld(Definitions.my_string_dtor, -0x1_60c3); /* call 0x10141b2a */
        l_0x1015_7bed:
            ii(0x1015_7bed, 2); jmpd(0x1015_7c1a, 0x2b); goto l_0x1015_7c1a; /* jmp 0x10157c1a */
        l_0x1015_7bef:
            ii(0x1015_7bef, 4); cmp(memd_a32[ss, ebp - 0x14], 0x4d);    /* cmp dword [ebp-0x14], 0x4d */
            ii(0x1015_7bf3, 2); if(jbd(0x1015_7c0b, 0x16)) goto l_0x1015_7c0b; /* jb 0x10157c0b */
            ii(0x1015_7bf5, 4); cmp(memd_a32[ss, ebp - 0x14], 0x4d);    /* cmp dword [ebp-0x14], 0x4d */
            ii(0x1015_7bf9, 6); if(jbed(0x1015_7b77, -0x88)) goto l_0x1015_7b77; /* jbe 0x10157b77 */
            ii(0x1015_7bff, 4); cmp(memd_a32[ss, ebp - 0x14], 0x4e);    /* cmp dword [ebp-0x14], 0x4e */
            ii(0x1015_7c03, 6); if(jzd(0x1015_7b6b, -0x9e)) goto l_0x1015_7b6b; /* jz 0x10157b6b */
            ii(0x1015_7c09, 2); jmpd(0x1015_7b8f, -0x7c); goto l_0x1015_7b8f; /* jmp 0x10157b8f */
        l_0x1015_7c0b:
            ii(0x1015_7c0b, 4); cmp(memd_a32[ss, ebp - 0x14], 0x46);    /* cmp dword [ebp-0x14], 0x46 */
            ii(0x1015_7c0f, 6); if(jzd(0x1015_7b83, -0x92)) goto l_0x1015_7b83; /* jz 0x10157b83 */
            ii(0x1015_7c15, 5); jmpd(0x1015_7b8f, -0x8b); goto l_0x1015_7b8f; /* jmp 0x10157b8f */
        l_0x1015_7c1a:
            ii(0x1015_7c1a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_7c1d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_7c20, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_7c23, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_7c25, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_7c26, 1); popd(edi);                              /* pop edi */
            ii(0x1015_7c27, 1); popd(esi);                              /* pop esi */
            ii(0x1015_7c28, 3); retd(0x34);                             /* ret 0x34 */
        }
    }
}
