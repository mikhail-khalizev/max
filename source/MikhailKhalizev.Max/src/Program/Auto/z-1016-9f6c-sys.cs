using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b56a2dad-b5c6-4697-a8cb-5c8bd472ab82")]
        public void /* sys */ Method_1016_9f6c()
        {
            ii(0x1016_9f6c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_9f6d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9f6e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_9f6f, 1); pushd(esi);                             /* push esi */
            ii(0x1016_9f70, 1); pushd(edi);                             /* push edi */
            ii(0x1016_9f71, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_9f72, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_9f75, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_9f77, 1); pushd(eax);                             /* push eax */
            ii(0x1016_9f78, 5); pushd(StringDefinitions.FontDFon);      /* push 0x101b2de4 */
            ii(0x1016_9f7d, 4); lea(eax, esp + 0x8);                    /* lea eax, [esp+0x8] */
            ii(0x1016_9f81, 1); pushd(eax);                             /* push eax */
            ii(0x1016_9f82, 5); calld(Definitions.sys_sprintf, -0x4086); /* call 0x10165f01 */
            ii(0x1016_9f87, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1016_9f8a, 5); mov(edx, StringDefinitions.Rb);         /* mov edx, 0x101b2df0 */
            ii(0x1016_9f8f, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_9f91, 5); calld(Definitions.sys_fopen_internal, 0x482e); /* call 0x1016e7c4 */
            ii(0x1016_9f96, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_9f98, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9f9a, 2); if(jnzd(0x1016_9fa6, 0xa)) goto l_0x1016_9fa6; /* jnz 0x10169fa6 */
            ii(0x1016_9f9c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_9fa1, 5); jmpd(0x1016_a0e4, 0x13e); goto l_0x1016_a0e4; /* jmp 0x1016a0e4 */
        l_0x1016_9fa6:
            ii(0x1016_9fa6, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_9fab, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_9fad, 3); shl(edi, 0x2);                          /* shl edi, 0x2 */
            ii(0x1016_9fb0, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x1016_9fb5, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1016_9fb7, 5); mov(eax, 0x101c_f6e4);                  /* mov eax, 0x101cf6e4 */
            ii(0x1016_9fbc, 3); shl(edi, 0x2);                          /* shl edi, 0x2 */
            ii(0x1016_9fbf, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_9fc1, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1016_9fc3, 5); calld(Definitions.sys_fread_internal, 0x4aa4); /* call 0x1016ea6c */
            ii(0x1016_9fc8, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1016_9fcb, 2); if(jzd(0x1016_9fe3, 0x16)) goto l_0x1016_9fe3; /* jz 0x10169fe3 */
            ii(0x1016_9fcd, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9fcf, 5); calld(Definitions.sys_fclose_internal, 0x6fa4); /* call 0x10170f78 */
            ii(0x1016_9fd4, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_9fd9, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_9fdc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_9fdd, 1); popd(edi);                              /* pop edi */
            ii(0x1016_9fde, 1); popd(esi);                              /* pop esi */
            ii(0x1016_9fdf, 1); popd(edx);                              /* pop edx */
            ii(0x1016_9fe0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_9fe1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_9fe2, 1); retd(); return;                         /* ret */
        l_0x1016_9fe3:
            ii(0x1016_9fe3, 6); mov(eax, memd_a32[ds, edi + 0x101c_f6e4]); /* mov eax, [edi+0x101cf6e4] */
            ii(0x1016_9fe9, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1016_9fec, 5); calld(Definitions.sys_malloc_internal, 0x182ff); /* call 0x101822f0 */
            ii(0x1016_9ff1, 6); mov(memd_a32[ds, edi + 0x101c_f6f0], eax); /* mov [edi+0x101cf6f0], eax */
            ii(0x1016_9ff7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9ff9, 2); if(jnzd(0x1016_a011, 0x16)) goto l_0x1016_a011; /* jnz 0x1016a011 */
            ii(0x1016_9ffb, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_9ffd, 5); calld(Definitions.sys_fclose_internal, 0x6f76); /* call 0x10170f78 */
            ii(0x1016_a002, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_a007, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_a00a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_a00b, 1); popd(edi);                              /* pop edi */
            ii(0x1016_a00c, 1); popd(esi);                              /* pop esi */
            ii(0x1016_a00d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_a00e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_a00f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_a010, 1); retd(); return;                         /* ret */
        l_0x1016_a011:
            ii(0x1016_a011, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1016_a016, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_a018, 6); mov(ebx, memd_a32[ds, edi + 0x101c_f6e4]); /* mov ebx, [edi+0x101cf6e4] */
            ii(0x1016_a01e, 5); calld(Definitions.sys_fread_internal, 0x4a49); /* call 0x1016ea6c */
            ii(0x1016_a023, 6); mov(edx, memd_a32[ds, edi + 0x101c_f6e4]); /* mov edx, [edi+0x101cf6e4] */
            ii(0x1016_a029, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_a02b, 2); if(jzd(0x1016_a047, 0x1a)) goto l_0x1016_a047; /* jz 0x1016a047 */
            ii(0x1016_a02d, 6); mov(eax, memd_a32[ds, edi + 0x101c_f6f0]); /* mov eax, [edi+0x101cf6f0] */
            ii(0x1016_a033, 5); calld(Definitions.sys_free_internal, 0x1841c); /* call 0x10182454 */
            ii(0x1016_a038, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_a03d, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_a040, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_a041, 1); popd(edi);                              /* pop edi */
            ii(0x1016_a042, 1); popd(esi);                              /* pop esi */
            ii(0x1016_a043, 1); popd(edx);                              /* pop edx */
            ii(0x1016_a044, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_a045, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_a046, 1); retd(); return;                         /* ret */
        l_0x1016_a047:
            ii(0x1016_a047, 3); lea(eax, edx - 0x1);                    /* lea eax, [edx-0x1] */
            ii(0x1016_a04a, 6); mov(ebx, memd_a32[ds, edi + 0x101c_f6f0]); /* mov ebx, [edi+0x101cf6f0] */
            ii(0x1016_a050, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1016_a053, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_a055, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1016_a057, 3); add(ebx, 0x7);                          /* add ebx, 0x7 */
            ii(0x1016_a05a, 6); mov(ecx, memd_a32[ds, edi + 0x101c_f6e8]); /* mov ecx, [edi+0x101cf6e8] */
            ii(0x1016_a060, 3); sar(ebx, 0x3);                          /* sar ebx, 0x3 */
            ii(0x1016_a063, 3); imul(ebx, ecx);                         /* imul ebx, ecx */
            ii(0x1016_a066, 3); mov(ebp, memd_a32[ds, eax + 0x4]);      /* mov ebp, [eax+0x4] */
            ii(0x1016_a069, 2); add(ebp, ebx);                          /* add ebp, ebx */
            ii(0x1016_a06b, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_a06d, 5); calld(Definitions.sys_malloc_internal, 0x1827e); /* call 0x101822f0 */
            ii(0x1016_a072, 6); mov(memd_a32[ds, edi + 0x101c_f6f4], eax); /* mov [edi+0x101cf6f4], eax */
            ii(0x1016_a078, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_a07a, 2); if(jnzd(0x1016_a09d, 0x21)) goto l_0x1016_a09d; /* jnz 0x1016a09d */
            ii(0x1016_a07c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_a07e, 5); calld(Definitions.sys_fclose_internal, 0x6ef5); /* call 0x10170f78 */
            ii(0x1016_a083, 6); mov(eax, memd_a32[ds, edi + 0x101c_f6f0]); /* mov eax, [edi+0x101cf6f0] */
            ii(0x1016_a089, 5); calld(Definitions.sys_free_internal, 0x183c6); /* call 0x10182454 */
            ii(0x1016_a08e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_a093, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_a096, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_a097, 1); popd(edi);                              /* pop edi */
            ii(0x1016_a098, 1); popd(esi);                              /* pop esi */
            ii(0x1016_a099, 1); popd(edx);                              /* pop edx */
            ii(0x1016_a09a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_a09b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_a09c, 1); retd(); return;                         /* ret */
        l_0x1016_a09d:
            ii(0x1016_a09d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_a0a2, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_a0a4, 2); mov(ebx, ebp);                          /* mov ebx, ebp */
            ii(0x1016_a0a6, 5); calld(Definitions.sys_fread_internal, 0x49c1); /* call 0x1016ea6c */
            ii(0x1016_a0ab, 2); cmp(eax, ebp);                          /* cmp eax, ebp */
            ii(0x1016_a0ad, 2); if(jzd(0x1016_a0db, 0x2c)) goto l_0x1016_a0db; /* jz 0x1016a0db */
            ii(0x1016_a0af, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_a0b1, 5); calld(Definitions.sys_fclose_internal, 0x6ec2); /* call 0x10170f78 */
            ii(0x1016_a0b6, 6); mov(eax, memd_a32[ds, edi + 0x101c_f6f0]); /* mov eax, [edi+0x101cf6f0] */
            ii(0x1016_a0bc, 5); calld(Definitions.sys_free_internal, 0x18393); /* call 0x10182454 */
            ii(0x1016_a0c1, 6); mov(eax, memd_a32[ds, edi + 0x101c_f6f4]); /* mov eax, [edi+0x101cf6f4] */
            ii(0x1016_a0c7, 5); calld(Definitions.sys_free_internal, 0x18388); /* call 0x10182454 */
            ii(0x1016_a0cc, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_a0d1, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_a0d4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_a0d5, 1); popd(edi);                              /* pop edi */
            ii(0x1016_a0d6, 1); popd(esi);                              /* pop esi */
            ii(0x1016_a0d7, 1); popd(edx);                              /* pop edx */
            ii(0x1016_a0d8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_a0d9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_a0da, 1); retd(); return;                         /* ret */
        l_0x1016_a0db:
            ii(0x1016_a0db, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_a0dd, 5); calld(Definitions.sys_fclose_internal, 0x6e96); /* call 0x10170f78 */
            ii(0x1016_a0e2, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_a0e4:
            ii(0x1016_a0e4, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_a0e7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_a0e8, 1); popd(edi);                              /* pop edi */
            ii(0x1016_a0e9, 1); popd(esi);                              /* pop esi */
            ii(0x1016_a0ea, 1); popd(edx);                              /* pop edx */
            ii(0x1016_a0eb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_a0ec, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_a0ed, 1); retd(); return;                         /* ret */
        }
    }
}
