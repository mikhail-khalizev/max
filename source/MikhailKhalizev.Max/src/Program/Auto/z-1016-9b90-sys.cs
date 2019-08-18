using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_9b90-1c767b29")]
        public void /* sys */ Method_1016_9b90()
        {
            ii(0x1016_9b90, 1); pushd(esi);                             /* push esi */
            ii(0x1016_9b91, 1); pushd(edi);                             /* push edi */
            ii(0x1016_9b92, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_9b93, 3); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1016_9b96, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1016_9b98, 4); mov(memd_a32[ss, esp + 0x24], edx);     /* mov [esp+0x24], edx */
            ii(0x1016_9b9c, 4); mov(memd_a32[ss, esp + 0x28], ebx);     /* mov [esp+0x28], ebx */
            ii(0x1016_9ba0, 4); mov(memd_a32[ss, esp + 0x20], ecx);     /* mov [esp+0x20], ecx */
            ii(0x1016_9ba4, 4); mov(edx, memd_a32[ss, esp + 0x3c]);     /* mov edx, [esp+0x3c] */
            ii(0x1016_9ba8, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_9baa, 6); if(jzd(0x1016_9d96, 0x1e6)) goto l_0x1016_9d96; /* jz 0x10169d96 */
            ii(0x1016_9bb0, 4); lea(edi, esp + 0x10);                   /* lea edi, [esp+0x10] */
            ii(0x1016_9bb4, 3); lea(esi, ebp + 0x8);                    /* lea esi, [ebp+0x8] */
            ii(0x1016_9bb7, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9bb8, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9bb9, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9bba, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9bbb, 4); mov(eax, memd_a32[ss, esp + 0x24]);     /* mov eax, [esp+0x24] */
            ii(0x1016_9bbf, 4); mov(ecx, memd_a32[ss, esp + 0x10]);     /* mov ecx, [esp+0x10] */
            ii(0x1016_9bc3, 3); add(ecx, memd_a32[ds, eax + 0x8]);      /* add ecx, [eax+0x8] */
            ii(0x1016_9bc6, 4); mov(eax, memd_a32[ss, esp + 0x24]);     /* mov eax, [esp+0x24] */
            ii(0x1016_9bca, 4); mov(memd_a32[ss, esp + 0x10], ecx);     /* mov [esp+0x10], ecx */
            ii(0x1016_9bce, 4); mov(esi, memd_a32[ss, esp + 0x14]);     /* mov esi, [esp+0x14] */
            ii(0x1016_9bd2, 3); add(esi, memd_a32[ds, eax + 0xc]);      /* add esi, [eax+0xc] */
            ii(0x1016_9bd5, 4); mov(eax, memd_a32[ss, esp + 0x24]);     /* mov eax, [esp+0x24] */
            ii(0x1016_9bd9, 4); mov(memd_a32[ss, esp + 0x14], esi);     /* mov [esp+0x14], esi */
            ii(0x1016_9bdd, 4); mov(edi, memd_a32[ss, esp + 0x18]);     /* mov edi, [esp+0x18] */
            ii(0x1016_9be1, 3); add(edi, memd_a32[ds, eax + 0x8]);      /* add edi, [eax+0x8] */
            ii(0x1016_9be4, 4); mov(eax, memd_a32[ss, esp + 0x24]);     /* mov eax, [esp+0x24] */
            ii(0x1016_9be8, 4); mov(memd_a32[ss, esp + 0x18], edi);     /* mov [esp+0x18], edi */
            ii(0x1016_9bec, 4); mov(ebx, memd_a32[ss, esp + 0x1c]);     /* mov ebx, [esp+0x1c] */
            ii(0x1016_9bf0, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1016_9bf3, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1016_9bf5, 4); mov(memd_a32[ss, esp + 0x1c], ebx);     /* mov [esp+0x1c], ebx */
            ii(0x1016_9bf9, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_9bfb, 2); if(jzd(0x1016_9c46, 0x49)) goto l_0x1016_9c46; /* jz 0x10169c46 */
            ii(0x1016_9bfd, 4); lea(ebx, esp + 0x10);                   /* lea ebx, [esp+0x10] */
            ii(0x1016_9c01, 4); lea(eax, esp + 0x10);                   /* lea eax, [esp+0x10] */
            ii(0x1016_9c05, 5); calld(/* sys */ 0x1018_5f8c, 0x1_c382); /* call 0x10185f8c */
            ii(0x1016_9c0a, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_9c0d, 6); if(jzd(0x1016_9d96, 0x183)) goto l_0x1016_9d96; /* jz 0x10169d96 */
            ii(0x1016_9c13, 4); mov(edx, memd_a32[ss, esp + 0x24]);     /* mov edx, [esp+0x24] */
            ii(0x1016_9c17, 4); mov(eax, memd_a32[ss, esp + 0x10]);     /* mov eax, [esp+0x10] */
            ii(0x1016_9c1b, 3); mov(ecx, memd_a32[ds, edx + 0x8]);      /* mov ecx, [edx+0x8] */
            ii(0x1016_9c1e, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_9c20, 3); mov(esi, memd_a32[ds, edx + 0xc]);      /* mov esi, [edx+0xc] */
            ii(0x1016_9c23, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_9c26, 4); mov(eax, memd_a32[ss, esp + 0x14]);     /* mov eax, [esp+0x14] */
            ii(0x1016_9c2a, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1016_9c2c, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1016_9c30, 4); mov(eax, memd_a32[ss, esp + 0x18]);     /* mov eax, [esp+0x18] */
            ii(0x1016_9c34, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_9c36, 4); mov(memd_a32[ss, esp + 0x8], eax);      /* mov [esp+0x8], eax */
            ii(0x1016_9c3a, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_9c3e, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1016_9c40, 4); mov(memd_a32[ss, esp + 0xc], eax);      /* mov [esp+0xc], eax */
            ii(0x1016_9c44, 2); jmpd(0x1016_9c4f, 0x9); goto l_0x1016_9c4f; /* jmp 0x10169c4f */
        l_0x1016_9c46:
            ii(0x1016_9c46, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1016_9c48, 3); lea(esi, ebp + 0x8);                    /* lea esi, [ebp+0x8] */
            ii(0x1016_9c4b, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9c4c, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9c4d, 1); movsd_a32();                            /* movsd */
            ii(0x1016_9c4e, 1); movsd_a32();                            /* movsd */
        l_0x1016_9c4f:
            ii(0x1016_9c4f, 4); mov(eax, memd_a32[ss, esp + 0x28]);     /* mov eax, [esp+0x28] */
            ii(0x1016_9c53, 3); cmp(eax, memd_a32[ss, ebp + 0x30]);     /* cmp eax, [ebp+0x30] */
            ii(0x1016_9c56, 2); if(jnzd(0x1016_9c65, 0xd)) goto l_0x1016_9c65; /* jnz 0x10169c65 */
            ii(0x1016_9c58, 4); test(memb_a32[ss, ebp + 0x6], 0x2);     /* test byte [ebp+0x6], 0x2 */
            ii(0x1016_9c5c, 2); if(jzd(0x1016_9c65, 0x7)) goto l_0x1016_9c65; /* jz 0x10169c65 */
            ii(0x1016_9c5e, 3); mov(eax, memd_a32[ss, ebp + 0x34]);     /* mov eax, [ebp+0x34] */
            ii(0x1016_9c61, 4); mov(memd_a32[ss, esp + 0x28], eax);     /* mov [esp+0x28], eax */
        l_0x1016_9c65:
            ii(0x1016_9c65, 4); test(memb_a32[ss, ebp + 0x4], 0x8);     /* test byte [ebp+0x4], 0x8 */
            ii(0x1016_9c69, 2); if(jzd(0x1016_9c8d, 0x22)) goto l_0x1016_9c8d; /* jz 0x10169c8d */
            ii(0x1016_9c6b, 4); mov(eax, memd_a32[ss, esp + 0x28]);     /* mov eax, [esp+0x28] */
            ii(0x1016_9c6f, 3); cmp(eax, memd_a32[ss, ebp + 0x30]);     /* cmp eax, [ebp+0x30] */
            ii(0x1016_9c72, 2); if(jnzd(0x1016_9c79, 0x5)) goto l_0x1016_9c79; /* jnz 0x10169c79 */
            ii(0x1016_9c74, 3); mov(eax, memd_a32[ss, ebp + 0x3c]);     /* mov eax, [ebp+0x3c] */
            ii(0x1016_9c77, 2); jmpd(0x1016_9cad, 0x34); goto l_0x1016_9cad; /* jmp 0x10169cad */
        l_0x1016_9c79:
            ii(0x1016_9c79, 3); cmp(eax, memd_a32[ss, ebp + 0x34]);     /* cmp eax, [ebp+0x34] */
            ii(0x1016_9c7c, 2); if(jnzd(0x1016_9c83, 0x5)) goto l_0x1016_9c83; /* jnz 0x10169c83 */
            ii(0x1016_9c7e, 3); mov(eax, memd_a32[ss, ebp + 0x40]);     /* mov eax, [ebp+0x40] */
            ii(0x1016_9c81, 2); jmpd(0x1016_9cad, 0x2a); goto l_0x1016_9cad; /* jmp 0x10169cad */
        l_0x1016_9c83:
            ii(0x1016_9c83, 3); cmp(eax, memd_a32[ss, ebp + 0x38]);     /* cmp eax, [ebp+0x38] */
            ii(0x1016_9c86, 2); if(jnzd(0x1016_9cb1, 0x29)) goto l_0x1016_9cb1; /* jnz 0x10169cb1 */
            ii(0x1016_9c88, 3); mov(eax, memd_a32[ss, ebp + 0x44]);     /* mov eax, [ebp+0x44] */
            ii(0x1016_9c8b, 2); jmpd(0x1016_9cad, 0x20); goto l_0x1016_9cad; /* jmp 0x10169cad */
        l_0x1016_9c8d:
            ii(0x1016_9c8d, 4); mov(eax, memd_a32[ss, esp + 0x28]);     /* mov eax, [esp+0x28] */
            ii(0x1016_9c91, 3); cmp(eax, memd_a32[ss, ebp + 0x3c]);     /* cmp eax, [ebp+0x3c] */
            ii(0x1016_9c94, 2); if(jnzd(0x1016_9c9b, 0x5)) goto l_0x1016_9c9b; /* jnz 0x10169c9b */
            ii(0x1016_9c96, 3); mov(eax, memd_a32[ss, ebp + 0x30]);     /* mov eax, [ebp+0x30] */
            ii(0x1016_9c99, 2); jmpd(0x1016_9cad, 0x12); goto l_0x1016_9cad; /* jmp 0x10169cad */
        l_0x1016_9c9b:
            ii(0x1016_9c9b, 3); cmp(eax, memd_a32[ss, ebp + 0x40]);     /* cmp eax, [ebp+0x40] */
            ii(0x1016_9c9e, 2); if(jnzd(0x1016_9ca5, 0x5)) goto l_0x1016_9ca5; /* jnz 0x10169ca5 */
            ii(0x1016_9ca0, 3); mov(eax, memd_a32[ss, ebp + 0x34]);     /* mov eax, [ebp+0x34] */
            ii(0x1016_9ca3, 2); jmpd(0x1016_9cad, 0x8); goto l_0x1016_9cad; /* jmp 0x10169cad */
        l_0x1016_9ca5:
            ii(0x1016_9ca5, 3); cmp(eax, memd_a32[ss, ebp + 0x44]);     /* cmp eax, [ebp+0x44] */
            ii(0x1016_9ca8, 2); if(jnzd(0x1016_9cb1, 0x7)) goto l_0x1016_9cb1; /* jnz 0x10169cb1 */
            ii(0x1016_9caa, 3); mov(eax, memd_a32[ss, ebp + 0x38]);     /* mov eax, [ebp+0x38] */
        l_0x1016_9cad:
            ii(0x1016_9cad, 4); mov(memd_a32[ss, esp + 0x28], eax);     /* mov [esp+0x28], eax */
        l_0x1016_9cb1:
            ii(0x1016_9cb1, 5); cmp(memd_a32[ss, esp + 0x28], 0);       /* cmp dword [esp+0x28], 0x0 */
            ii(0x1016_9cb6, 6); if(jzd(0x1016_9d96, 0xda)) goto l_0x1016_9d96; /* jz 0x10169d96 */
            ii(0x1016_9cbc, 5); cmp(memd_a32[ss, esp + 0x20], 0);       /* cmp dword [esp+0x20], 0x0 */
            ii(0x1016_9cc1, 6); if(jnzd(0x1016_9d78, 0xb1)) goto l_0x1016_9d78; /* jnz 0x10169d78 */
            ii(0x1016_9cc7, 3); mov(ebx, memd_a32[ss, esp]);            /* mov ebx, [esp] */
            ii(0x1016_9cca, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1016_9ccd, 3); mov(edx, memd_a32[ss, ebp + 0x8]);      /* mov edx, [ebp+0x8] */
            ii(0x1016_9cd0, 4); mov(ecx, memd_a32[ss, esp + 0x4]);      /* mov ecx, [esp+0x4] */
            ii(0x1016_9cd4, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_9cd6, 4); mov(edx, memd_a32[ss, esp + 0x8]);      /* mov edx, [esp+0x8] */
            ii(0x1016_9cda, 1); inc(eax);                               /* inc eax */
            ii(0x1016_9cdb, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1016_9cdd, 4); mov(ebx, memd_a32[ss, esp + 0xc]);      /* mov ebx, [esp+0xc] */
            ii(0x1016_9ce1, 1); inc(edx);                               /* inc edx */
            ii(0x1016_9ce2, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1016_9ce4, 3); mov(cl, memb_a32[ss, ebp + 0x4]);       /* mov cl, [ebp+0x4] */
            ii(0x1016_9ce7, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_9ce8, 3); test(cl, 0x20);                         /* test cl, 0x20 */
            ii(0x1016_9ceb, 2); if(jzd(0x1016_9d33, 0x46)) goto l_0x1016_9d33; /* jz 0x10169d33 */
            ii(0x1016_9ced, 4); mov(ecx, memd_a32[ss, esp + 0x24]);     /* mov ecx, [esp+0x24] */
            ii(0x1016_9cf1, 4); mov(esi, memd_a32[ss, esp + 0x24]);     /* mov esi, [esp+0x24] */
            ii(0x1016_9cf5, 3); mov(edi, memd_a32[ds, ecx + 0x18]);     /* mov edi, [ecx+0x18] */
            ii(0x1016_9cf8, 4); mov(ecx, memd_a32[ss, esp + 0x4]);      /* mov ecx, [esp+0x4] */
            ii(0x1016_9cfc, 1); pushd(edi);                             /* push edi */
            ii(0x1016_9cfd, 4); imul(ecx, memd_a32[ds, esi + 0x18]);    /* imul ecx, [esi+0x18] */
            ii(0x1016_9d01, 3); mov(esi, memd_a32[ds, esi + 0x2c]);     /* mov esi, [esi+0x2c] */
            ii(0x1016_9d04, 4); mov(edi, memd_a32[ss, esp + 0x4]);      /* mov edi, [esp+0x4] */
            ii(0x1016_9d08, 2); add(esi, edi);                          /* add esi, edi */
            ii(0x1016_9d0a, 2); add(ecx, esi);                          /* add ecx, esi */
            ii(0x1016_9d0c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9d0d, 1); pushd(eax);                             /* push eax */
            ii(0x1016_9d0e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_9d0f, 1); pushd(edx);                             /* push edx */
            ii(0x1016_9d10, 3); mov(ebx, memd_a32[ss, ebp + 0xc]);      /* mov ebx, [ebp+0xc] */
            ii(0x1016_9d13, 4); mov(edx, memd_a32[ss, esp + 0x18]);     /* mov edx, [esp+0x18] */
            ii(0x1016_9d17, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1016_9d19, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_9d1c, 4); mov(edx, memd_a32[ss, esp + 0x3c]);     /* mov edx, [esp+0x3c] */
            ii(0x1016_9d20, 3); mov(ecx, memd_a32[ss, ebp + 0x8]);      /* mov ecx, [ebp+0x8] */
            ii(0x1016_9d23, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_9d25, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_9d27, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_9d29, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_9d2b, 1); pushd(eax);                             /* push eax */
            ii(0x1016_9d2c, 5); calld(/* sys */ 0x1017_1e10, 0x80df);   /* call 0x10171e10 */
            ii(0x1016_9d31, 2); jmpd(0x1016_9d75, 0x42); goto l_0x1016_9d75; /* jmp 0x10169d75 */
        l_0x1016_9d33:
            ii(0x1016_9d33, 4); mov(ecx, memd_a32[ss, esp + 0x24]);     /* mov ecx, [esp+0x24] */
            ii(0x1016_9d37, 3); mov(esi, memd_a32[ds, ecx + 0x18]);     /* mov esi, [ecx+0x18] */
            ii(0x1016_9d3a, 3); mov(edi, memd_a32[ds, ecx + 0x18]);     /* mov edi, [ecx+0x18] */
            ii(0x1016_9d3d, 1); pushd(esi);                             /* push esi */
            ii(0x1016_9d3e, 4); mov(esi, memd_a32[ss, esp + 0x8]);      /* mov esi, [esp+0x8] */
            ii(0x1016_9d42, 3); imul(esi, edi);                         /* imul esi, edi */
            ii(0x1016_9d45, 3); mov(ecx, memd_a32[ds, ecx + 0x2c]);     /* mov ecx, [ecx+0x2c] */
            ii(0x1016_9d48, 4); mov(edi, memd_a32[ss, esp + 0x4]);      /* mov edi, [esp+0x4] */
            ii(0x1016_9d4c, 2); add(ecx, edi);                          /* add ecx, edi */
            ii(0x1016_9d4e, 2); add(ecx, esi);                          /* add ecx, esi */
            ii(0x1016_9d50, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9d51, 1); pushd(eax);                             /* push eax */
            ii(0x1016_9d52, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_9d53, 1); pushd(edx);                             /* push edx */
            ii(0x1016_9d54, 3); mov(ebx, memd_a32[ss, ebp + 0xc]);      /* mov ebx, [ebp+0xc] */
            ii(0x1016_9d57, 4); mov(edx, memd_a32[ss, esp + 0x18]);     /* mov edx, [esp+0x18] */
            ii(0x1016_9d5b, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1016_9d5d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1016_9d60, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1016_9d63, 4); mov(ecx, memd_a32[ss, esp + 0x3c]);     /* mov ecx, [esp+0x3c] */
            ii(0x1016_9d67, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_9d69, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1016_9d6b, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1016_9d6d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_9d6f, 1); pushd(eax);                             /* push eax */
            ii(0x1016_9d70, 5); calld(/* sys */ 0x1016_abbc, 0xe47);    /* call 0x1016abbc */
        l_0x1016_9d75:
            ii(0x1016_9d75, 3); add(esp, 0x18);                         /* add esp, 0x18 */
        l_0x1016_9d78:
            ii(0x1016_9d78, 4); mov(eax, memd_a32[ss, esp + 0x28]);     /* mov eax, [esp+0x28] */
            ii(0x1016_9d7c, 4); mov(esi, memd_a32[ss, esp + 0x20]);     /* mov esi, [esp+0x20] */
            ii(0x1016_9d80, 3); mov(memd_a32[ss, ebp + 0x48], eax);     /* mov [ebp+0x48], eax */
            ii(0x1016_9d83, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_9d85, 2); if(jzd(0x1016_9d96, 0xf)) goto l_0x1016_9d96; /* jz 0x10169d96 */
            ii(0x1016_9d87, 4); lea(edx, esp + 0x10);                   /* lea edx, [esp+0x10] */
            ii(0x1016_9d8b, 4); mov(eax, memd_a32[ss, esp + 0x24]);     /* mov eax, [esp+0x24] */
            ii(0x1016_9d8f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_9d91, 5); calld(/* sys */ 0x1016_7500, -0x2896);  /* call 0x10167500 */
        l_0x1016_9d96:
            ii(0x1016_9d96, 3); add(esp, 0x2c);                         /* add esp, 0x2c */
            ii(0x1016_9d99, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_9d9a, 1); popd(edi);                              /* pop edi */
            ii(0x1016_9d9b, 1); popd(esi);                              /* pop esi */
            ii(0x1016_9d9c, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
